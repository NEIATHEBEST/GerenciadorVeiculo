using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    internal class Aluno
    {
        private string nome, cpf, ra; //string, quantidade maiores de caracteres que o int, quando ñ precisa fazer cálculos, pode ser string, mas da pra converter dps
        private int idade;

        // *sempre tentar usar o modificador que mais restrinja as informações
        // get - consultar, set - atribuir valor
        // protected - quando herda características de uma classe pai, por encapsulamento
        // private - só é possivel acessar por get e set
        // void - indica que a função não tem retorno
        // this. - acompanha o atributo da classe sempre, pra diferenciar oq é atributo e o que é a informação que o usuário vai digitar
        // usa toda vez que precisar identificar que o objeto é um atributo da classe
        // objeto - instância, exemplo da classe

        public string getNome() { return nome; }
        public void setNome(string nome) { this.nome = nome; }

        public string getCpf() { return cpf; }
        public void setCpf(string cpf) { this.cpf = cpf; }

        public string getRa() { return ra; }
        public void setRa(string ra) { this.ra = ra; }

        public int getIdade() { return idade; }
        public void setIdade(int idade) { this.idade = idade; }

        /* public void ImprimirInformacoes()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Cpf: " + this.cpf);
            Console.WriteLine("Ra: " + this.ra);
            Console.WriteLine("Idade: " + this.idade);
        }

        // Criando objetos
        public static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            aluno1.setNome("Maria");
            aluno1.setRa("12345");
            aluno1.setCpf("908765432-11");
            aluno1.setIdade(18);
            // informar qual informação/valor quer adicionar aos objetos
        } */
    }
}
