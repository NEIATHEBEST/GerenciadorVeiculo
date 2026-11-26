USE bd2_prova_gestao_hospitalar;

-- ============================================================
-- QUESTAO 1: Recepcao e Triagem 
-- ============================================================
CREATE VIEW vw_recepcao_pacientes_triagem AS
SELECT id_paciente,nome_paciente,cidade_origem,convenio_medico,
    REPLACE(cpf_paciente, SUBSTRING(cpf_paciente, 5, 7), '***.***') AS cpf_mascarado,
    REPLACE(cartao_sus, SUBSTRING(cartao_sus, 1, LENGTH(cartao_sus) - 4), 'SUS Final ****.') AS cartao_sus_final,
    REPLACE(telefone_contato, SUBSTRING(telefone_contato, 6, 6), '*****-') AS telefone_mascarado
FROM pacientes
ORDER BY nome_paciente ASC;

SELECT * FROM vw_recepcao_pacientes_triagem;

-- ============================================================
-- QUESTAO 2: Recursos Humanos (Não tão humanos)
-- ============================================================
CREATE VIEW vw_rh_corpo_clinico_seguro AS
SELECT p.id_profissional,p.nome_profissional,p.cargo_funcao,p.registro_conselho,s.sigla_setor,s.nome_setor,p.turno_trabalho,
    REPLACE(p.cpf, SUBSTRING(p.cpf, 5, 7), '***.***') AS cpf_protegido,
    REPLACE(p.conta_bancaria_repasse, SUBSTRING(p.conta_bancaria_repasse, 1, LENGTH(p.conta_bancaria_repasse) - 7), 'Conta Final ****-') AS conta_repasse_final,
    CASE
        WHEN (p.salario_base + p.adicional_insalubridade) >= 15000.00 THEN 'Faixa Senior (Acima de 15 mil)'
        WHEN (p.salario_base + p.adicional_insalubridade) >= 9000.00 THEN 'Faixa Plena (9 mil a 14.999)'
        ELSE 'Faixa Inicial (Ate 8.999)'
    END AS faixa_remuneracao,
    p.status_profissional
FROM profissionais_saude p
INNER JOIN setores_hospitalares s
    ON p.id_setor = s.id_setor
WHERE p.status_profissional = 'Ativo'
ORDER BY s.nome_setor ASC, p.nome_profissional ASC;

SELECT * FROM vw_rh_corpo_clinico_seguro;

-- ============================================================
-- QUESTAO 3: Diretoria Financeira e de Operacoes
-- ============================================================
CREATE VIEW vw_diretoria_desempenho_setores AS
SELECT s.sigla_setor,s.nome_setor,s.coordenador_setor,
    COUNT(a.id_atendimento) AS total_atendimentos,
    CASE
        WHEN COUNT(a.id_atendimento) >= 4 AND COALESCE(SUM(a.valor_faturado), 0) >= 8000.00 THEN 'Alta Demanda e Faturamento'
        WHEN COUNT(a.id_atendimento) >= 1 THEN 'Operacao Regular'
        ELSE 'Setor Sem Movimentacao'
    END AS classificacao_setor
FROM setores_hospitalares s
LEFT JOIN atendimentos_medicos a
    ON a.id_setor = s.id_setor
GROUP BY s.id_setor, s.sigla_setor, s.nome_setor, s.coordenador_setor
ORDER BY total_atendimentos DESC, s.nome_setor ASC;

SELECT * FROM vw_diretoria_desempenho_setores;