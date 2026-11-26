namespace SistemaEscolar
{
    partial class frmCadastroAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_ra = new System.Windows.Forms.Label();
            this.txt_cpfA = new System.Windows.Forms.TextBox();
            this.txt_idadeA = new System.Windows.Forms.TextBox();
            this.txt_raA = new System.Windows.Forms.TextBox();
            this.btn_cadastrarA = new System.Windows.Forms.Button();
            this.btn_limparA = new System.Windows.Forms.Button();
            this.lbl_dadosA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomeA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(428, 207);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idade.Location = new System.Drawing.Point(428, 295);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(54, 20);
            this.lbl_idade.TabIndex = 1;
            this.lbl_idade.Text = "Idade:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(430, 251);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(44, 20);
            this.lbl_cpf.TabIndex = 2;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_ra
            // 
            this.lbl_ra.AutoSize = true;
            this.lbl_ra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ra.Location = new System.Drawing.Point(428, 339);
            this.lbl_ra.Name = "lbl_ra";
            this.lbl_ra.Size = new System.Drawing.Size(36, 20);
            this.lbl_ra.TabIndex = 3;
            this.lbl_ra.Text = "RA:";
            // 
            // txt_cpfA
            // 
            this.txt_cpfA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cpfA.Location = new System.Drawing.Point(498, 254);
            this.txt_cpfA.Name = "txt_cpfA";
            this.txt_cpfA.Size = new System.Drawing.Size(132, 20);
            this.txt_cpfA.TabIndex = 5;
            // 
            // txt_idadeA
            // 
            this.txt_idadeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idadeA.Location = new System.Drawing.Point(498, 298);
            this.txt_idadeA.Name = "txt_idadeA";
            this.txt_idadeA.Size = new System.Drawing.Size(132, 20);
            this.txt_idadeA.TabIndex = 6;
            // 
            // txt_raA
            // 
            this.txt_raA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_raA.Location = new System.Drawing.Point(498, 342);
            this.txt_raA.Name = "txt_raA";
            this.txt_raA.Size = new System.Drawing.Size(132, 20);
            this.txt_raA.TabIndex = 7;
            // 
            // btn_cadastrarA
            // 
            this.btn_cadastrarA.BackColor = System.Drawing.Color.Plum;
            this.btn_cadastrarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrarA.Location = new System.Drawing.Point(687, 241);
            this.btn_cadastrarA.Name = "btn_cadastrarA";
            this.btn_cadastrarA.Size = new System.Drawing.Size(102, 34);
            this.btn_cadastrarA.TabIndex = 8;
            this.btn_cadastrarA.Text = "Cadastrar";
            this.btn_cadastrarA.UseVisualStyleBackColor = false;
            this.btn_cadastrarA.Click += new System.EventHandler(this.btn_cadastrarA_Click_1);
            // 
            // btn_limparA
            // 
            this.btn_limparA.BackColor = System.Drawing.Color.Plum;
            this.btn_limparA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparA.Location = new System.Drawing.Point(687, 298);
            this.btn_limparA.Name = "btn_limparA";
            this.btn_limparA.Size = new System.Drawing.Size(102, 34);
            this.btn_limparA.TabIndex = 9;
            this.btn_limparA.Text = "Limpar";
            this.btn_limparA.UseVisualStyleBackColor = false;
            // 
            // lbl_dadosA
            // 
            this.lbl_dadosA.AutoSize = true;
            this.lbl_dadosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dadosA.Location = new System.Drawing.Point(579, 413);
            this.lbl_dadosA.Name = "lbl_dadosA";
            this.lbl_dadosA.Size = new System.Drawing.Size(71, 20);
            this.lbl_dadosA.TabIndex = 10;
            this.lbl_dadosA.Text = "DADOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(509, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "ALUNOS";
            // 
            // txt_nomeA
            // 
            this.txt_nomeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nomeA.Location = new System.Drawing.Point(498, 210);
            this.txt_nomeA.Name = "txt_nomeA";
            this.txt_nomeA.Size = new System.Drawing.Size(132, 20);
            this.txt_nomeA.TabIndex = 4;
            // 
            // frmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1156, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dadosA);
            this.Controls.Add(this.btn_limparA);
            this.Controls.Add(this.btn_cadastrarA);
            this.Controls.Add(this.txt_raA);
            this.Controls.Add(this.txt_idadeA);
            this.Controls.Add(this.txt_cpfA);
            this.Controls.Add(this.txt_nomeA);
            this.Controls.Add(this.lbl_ra);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frmCadastroAluno";
            this.Text = "Sistema Escolar - Cadastro Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_ra;
        private System.Windows.Forms.TextBox txt_cpfA;
        private System.Windows.Forms.TextBox txt_idadeA;
        private System.Windows.Forms.TextBox txt_raA;
        private System.Windows.Forms.Button btn_cadastrarA;
        private System.Windows.Forms.Button btn_limparA;
        private System.Windows.Forms.Label lbl_dadosA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomeA;
    }
}

