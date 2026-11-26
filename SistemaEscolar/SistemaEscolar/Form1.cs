using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btn_cadastrarA_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cadastrarA_Click_1(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.setNome(txt_nomeA.Text);
            aluno.setIdade(Convert.ToInt32(txt_idadeA.Text));
            aluno.setCpf(txt_cpfA.Text);
            aluno.setRa(txt_raA.Text);

            lbl_dadosA.Text = "DADOS: \n\n" + "Nome: " + aluno.getNome() + "\n CPF: " + aluno.getCpf() + "\n Idade: " + aluno.getIdade() + "\n RA: " + aluno.getRa();

        }
    }
}
