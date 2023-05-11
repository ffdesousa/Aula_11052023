
namespace Aula_15052023
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grp_MediaGeral = new System.Windows.Forms.GroupBox();
            this.Txt_MediaGeral = new System.Windows.Forms.TextBox();
            this.Grp_DadosAluno = new System.Windows.Forms.GroupBox();
            this.Dtp_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_NotaFinal = new System.Windows.Forms.Label();
            this.Lbl_Idade = new System.Windows.Forms.Label();
            this.Lbl_DataNascimento = new System.Windows.Forms.Label();
            this.Lbl_NomeAluno = new System.Windows.Forms.Label();
            this.Txt_Idade = new System.Windows.Forms.TextBox();
            this.Txt_NotaFinal = new System.Windows.Forms.TextBox();
            this.Txt_NomeAluno = new System.Windows.Forms.TextBox();
            this.Btn_IncluirAluno = new System.Windows.Forms.Button();
            this.Btn_ReavaliarAlunos = new System.Windows.Forms.Button();
            this.Grp_Alunos = new System.Windows.Forms.GroupBox();
            this.Grd_Alunos = new System.Windows.Forms.DataGridView();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp_MediaGeral.SuspendLayout();
            this.Grp_DadosAluno.SuspendLayout();
            this.Grp_Alunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_MediaGeral
            // 
            this.Grp_MediaGeral.Controls.Add(this.Txt_MediaGeral);
            this.Grp_MediaGeral.Location = new System.Drawing.Point(12, 33);
            this.Grp_MediaGeral.Name = "Grp_MediaGeral";
            this.Grp_MediaGeral.Size = new System.Drawing.Size(151, 120);
            this.Grp_MediaGeral.TabIndex = 0;
            this.Grp_MediaGeral.TabStop = false;
            this.Grp_MediaGeral.Text = "Média Geral";
            // 
            // Txt_MediaGeral
            // 
            this.Txt_MediaGeral.Location = new System.Drawing.Point(26, 45);
            this.Txt_MediaGeral.Name = "Txt_MediaGeral";
            this.Txt_MediaGeral.Size = new System.Drawing.Size(102, 20);
            this.Txt_MediaGeral.TabIndex = 0;
            this.Txt_MediaGeral.Leave += new System.EventHandler(this.Txt_MediaGeral_Leave);
            // 
            // Grp_DadosAluno
            // 
            this.Grp_DadosAluno.Controls.Add(this.Dtp_DataNascimento);
            this.Grp_DadosAluno.Controls.Add(this.lbl_NotaFinal);
            this.Grp_DadosAluno.Controls.Add(this.Lbl_Idade);
            this.Grp_DadosAluno.Controls.Add(this.Lbl_DataNascimento);
            this.Grp_DadosAluno.Controls.Add(this.Lbl_NomeAluno);
            this.Grp_DadosAluno.Controls.Add(this.Txt_Idade);
            this.Grp_DadosAluno.Controls.Add(this.Txt_NotaFinal);
            this.Grp_DadosAluno.Controls.Add(this.Txt_NomeAluno);
            this.Grp_DadosAluno.Location = new System.Drawing.Point(169, 33);
            this.Grp_DadosAluno.Name = "Grp_DadosAluno";
            this.Grp_DadosAluno.Size = new System.Drawing.Size(736, 120);
            this.Grp_DadosAluno.TabIndex = 1;
            this.Grp_DadosAluno.TabStop = false;
            this.Grp_DadosAluno.Text = "Dados do Aluno";
            // 
            // Dtp_DataNascimento
            // 
            this.Dtp_DataNascimento.CustomFormat = "dd-MM-yyyy";
            this.Dtp_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataNascimento.Location = new System.Drawing.Point(138, 58);
            this.Dtp_DataNascimento.MaxDate = new System.DateTime(2023, 5, 11, 0, 0, 0, 0);
            this.Dtp_DataNascimento.Name = "Dtp_DataNascimento";
            this.Dtp_DataNascimento.Size = new System.Drawing.Size(102, 20);
            this.Dtp_DataNascimento.TabIndex = 2;
            this.Dtp_DataNascimento.Value = new System.DateTime(2023, 5, 11, 0, 0, 0, 0);
            this.Dtp_DataNascimento.Leave += new System.EventHandler(this.Dtp_DataNascimento_Leave);
            // 
            // lbl_NotaFinal
            // 
            this.lbl_NotaFinal.AutoSize = true;
            this.lbl_NotaFinal.Location = new System.Drawing.Point(543, 62);
            this.lbl_NotaFinal.Name = "lbl_NotaFinal";
            this.lbl_NotaFinal.Size = new System.Drawing.Size(64, 13);
            this.lbl_NotaFinal.TabIndex = 7;
            this.lbl_NotaFinal.Text = "Média Final:";
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.AutoSize = true;
            this.Lbl_Idade.Location = new System.Drawing.Point(313, 62);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Idade.TabIndex = 6;
            this.Lbl_Idade.Text = "Idade:";
            // 
            // Lbl_DataNascimento
            // 
            this.Lbl_DataNascimento.AutoSize = true;
            this.Lbl_DataNascimento.Location = new System.Drawing.Point(15, 62);
            this.Lbl_DataNascimento.Name = "Lbl_DataNascimento";
            this.Lbl_DataNascimento.Size = new System.Drawing.Size(107, 13);
            this.Lbl_DataNascimento.TabIndex = 5;
            this.Lbl_DataNascimento.Text = "Data do Nascimento:";
            // 
            // Lbl_NomeAluno
            // 
            this.Lbl_NomeAluno.AutoSize = true;
            this.Lbl_NomeAluno.Location = new System.Drawing.Point(15, 33);
            this.Lbl_NomeAluno.Name = "Lbl_NomeAluno";
            this.Lbl_NomeAluno.Size = new System.Drawing.Size(83, 13);
            this.Lbl_NomeAluno.TabIndex = 4;
            this.Lbl_NomeAluno.Text = "Nome do Aluno:";
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.Location = new System.Drawing.Point(356, 59);
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.ReadOnly = true;
            this.Txt_Idade.Size = new System.Drawing.Size(93, 20);
            this.Txt_Idade.TabIndex = 3;
            // 
            // Txt_NotaFinal
            // 
            this.Txt_NotaFinal.Location = new System.Drawing.Point(613, 59);
            this.Txt_NotaFinal.Name = "Txt_NotaFinal";
            this.Txt_NotaFinal.Size = new System.Drawing.Size(93, 20);
            this.Txt_NotaFinal.TabIndex = 4;
            this.Txt_NotaFinal.TextChanged += new System.EventHandler(this.Txt_NotaFinal_TextChanged);
            // 
            // Txt_NomeAluno
            // 
            this.Txt_NomeAluno.Location = new System.Drawing.Point(138, 30);
            this.Txt_NomeAluno.Name = "Txt_NomeAluno";
            this.Txt_NomeAluno.Size = new System.Drawing.Size(568, 20);
            this.Txt_NomeAluno.TabIndex = 1;
            this.Txt_NomeAluno.Leave += new System.EventHandler(this.Txt_NomeAluno_Leave);
            // 
            // Btn_IncluirAluno
            // 
            this.Btn_IncluirAluno.Location = new System.Drawing.Point(706, 171);
            this.Btn_IncluirAluno.Name = "Btn_IncluirAluno";
            this.Btn_IncluirAluno.Size = new System.Drawing.Size(75, 23);
            this.Btn_IncluirAluno.TabIndex = 5;
            this.Btn_IncluirAluno.Text = "Incluir Aluno";
            this.Btn_IncluirAluno.UseVisualStyleBackColor = true;
            this.Btn_IncluirAluno.Click += new System.EventHandler(this.Btn_IncluirAluno_Click);
            // 
            // Btn_ReavaliarAlunos
            // 
            this.Btn_ReavaliarAlunos.Location = new System.Drawing.Point(796, 171);
            this.Btn_ReavaliarAlunos.Name = "Btn_ReavaliarAlunos";
            this.Btn_ReavaliarAlunos.Size = new System.Drawing.Size(109, 23);
            this.Btn_ReavaliarAlunos.TabIndex = 6;
            this.Btn_ReavaliarAlunos.Text = "Reavaliar Alunos";
            this.Btn_ReavaliarAlunos.UseVisualStyleBackColor = true;
            this.Btn_ReavaliarAlunos.Click += new System.EventHandler(this.Btn_ReavaliarAlunos_Click);
            // 
            // Grp_Alunos
            // 
            this.Grp_Alunos.Controls.Add(this.Grd_Alunos);
            this.Grp_Alunos.Location = new System.Drawing.Point(13, 215);
            this.Grp_Alunos.Name = "Grp_Alunos";
            this.Grp_Alunos.Size = new System.Drawing.Size(892, 326);
            this.Grp_Alunos.TabIndex = 1;
            this.Grp_Alunos.TabStop = false;
            this.Grp_Alunos.Text = "Alunos";
            // 
            // Grd_Alunos
            // 
            this.Grd_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Alunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAluno,
            this.DataNascimento,
            this.Idade,
            this.Nota,
            this.Situacao});
            this.Grd_Alunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Alunos.Location = new System.Drawing.Point(3, 16);
            this.Grd_Alunos.MultiSelect = false;
            this.Grd_Alunos.Name = "Grd_Alunos";
            this.Grd_Alunos.ReadOnly = true;
            this.Grd_Alunos.Size = new System.Drawing.Size(886, 307);
            this.Grd_Alunos.TabIndex = 9;
            this.Grd_Alunos.TabStop = false;
            // 
            // NomeAluno
            // 
            this.NomeAluno.HeaderText = "Nome do Aluno";
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.ReadOnly = true;
            this.NomeAluno.Width = 300;
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "Data de Nascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Width = 200;
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situacão";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 150;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 550);
            this.Controls.Add(this.Grp_Alunos);
            this.Controls.Add(this.Btn_ReavaliarAlunos);
            this.Controls.Add(this.Btn_IncluirAluno);
            this.Controls.Add(this.Grp_DadosAluno);
            this.Controls.Add(this.Grp_MediaGeral);
            this.Name = "FormMain";
            this.Text = "Sistema de Aprovações de Alunos";
            this.Grp_MediaGeral.ResumeLayout(false);
            this.Grp_MediaGeral.PerformLayout();
            this.Grp_DadosAluno.ResumeLayout(false);
            this.Grp_DadosAluno.PerformLayout();
            this.Grp_Alunos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Alunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_MediaGeral;
        private System.Windows.Forms.TextBox Txt_MediaGeral;
        private System.Windows.Forms.GroupBox Grp_DadosAluno;
        private System.Windows.Forms.DateTimePicker Dtp_DataNascimento;
        private System.Windows.Forms.Label lbl_NotaFinal;
        private System.Windows.Forms.Label Lbl_Idade;
        private System.Windows.Forms.Label Lbl_DataNascimento;
        private System.Windows.Forms.Label Lbl_NomeAluno;
        private System.Windows.Forms.TextBox Txt_Idade;
        private System.Windows.Forms.TextBox Txt_NotaFinal;
        private System.Windows.Forms.TextBox Txt_NomeAluno;
        private System.Windows.Forms.Button Btn_IncluirAluno;
        private System.Windows.Forms.Button Btn_ReavaliarAlunos;
        private System.Windows.Forms.GroupBox Grp_Alunos;
        private System.Windows.Forms.DataGridView Grd_Alunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}

