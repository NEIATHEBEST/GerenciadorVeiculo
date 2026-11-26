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
    public partial class frmCadastroProfessor : Form
    {
        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btn_cadastrarP_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();

            professor.setNome(txt_nomeP.Text);
            professor.setFormacao(txt_formacaoP.Text);
            professor.setEscola(txt_escolaP.Text);
            professor.setIdade(Convert.ToInt32(txt_idadeP.Text));
            professor.setQaulas(Convert.ToInt32(txt_aulasP.Text));

            lbl_dadosP.Text = "DADOS: \n\n" + "Nome: " + professor.getNome() + "\n Formação: " + professor.getFormacao() + "\n Escola: " + professor.getEscola() + "\n Idade: " + professor.getIdade() + "\n Quant. aulas: " + professor.getQaulas();
        }
    }
}
