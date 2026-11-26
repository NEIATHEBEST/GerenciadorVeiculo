using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    internal class Professor
    {
        private string nome, formacao, escola;
        private int idade, Qaulas;

        public string getNome() { return nome; }
        public void setNome(string nome) { this.nome = nome; }


        public string getFormacao() { return formacao; }
        public void setFormacao(string formacao) { this.formacao = formacao; }


        public string getEscola() { return escola; }
        public void setEscola(string escola) { this.escola = escola; }


        public int getIdade() { return idade; }
        public void setIdade(int idade) { this.idade = idade; }


        public int getQaulas() { return Qaulas; }
        public void setQaulas(int Qaulas) { this.Qaulas = Qaulas; }
    }

}