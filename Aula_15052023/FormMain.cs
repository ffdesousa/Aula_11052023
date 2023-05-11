using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_15052023
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private bool Validate_TxtMedia(string txt_valor)
        {
            string txt_message = "Informe um valor numérico!";
            float media = 0;

            if (!float.TryParse(txt_valor, out media) || String.IsNullOrEmpty(txt_valor))
            {
                MessageBox.Show(txt_message);
                return false;
            }

            return true;
        }

        private string Validate_situation(float average)
        {
            float overallAverage = (float)Convert.ToDecimal( this.Txt_MediaGeral.Text.Replace('.',','));

            if (average >= overallAverage)
            { 
                return "Aprovado"; 
            }

            return "Reprovado"; 
        }

        private void Txt_MediaGeral_Leave(object sender, EventArgs e)
        {
            if (!Validate_TxtMedia(this.Txt_MediaGeral.Text)) 
            {
                this.Txt_MediaGeral.Text = "";
                this.Txt_MediaGeral.Focus();
            }
        }
               
        private void Txt_NotaFinal_TextChanged(object sender, EventArgs e)
        {
            if (!Validate_TxtMedia(this.Txt_NotaFinal.Text))
            {
                this.Txt_NotaFinal.Text = "";
                this.Txt_NotaFinal.Focus();
            }
        }

        private void Btn_IncluirAluno_Click(object sender, EventArgs e)
        {
            this.Grd_Alunos.Rows.Insert(0, 
                                        this.Txt_NomeAluno.Text, 
                                        this.Dtp_DataNascimento.Value.ToString(), 
                                        this.Txt_Idade.Text, 
                                        this.Txt_NotaFinal.Text.Replace('.', ','), 
                                        this.Validate_situation(
                                            (float)Convert.ToDecimal(this.Txt_NotaFinal.Text.Replace('.', ','))
                                        ));
        }

        private void Dtp_DataNascimento_Leave(object sender, EventArgs e)
        {
            int idade = new DateTime((DateTime.Now - Dtp_DataNascimento.Value).Ticks).Year;
            this.Txt_Idade.Text = idade.ToString();
        }

        private void Btn_ReavaliarAlunos_Click(object sender, EventArgs e)
        {
            if (this.Grd_Alunos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in this.Grd_Alunos.Rows)
                    if (row.Cells["Situacao"].Value != null)
                    {
                        row.Cells["Situacao"].Value = this.Validate_situation((float)Convert.ToDecimal(row.Cells["Nota"].Value));
                    }
            }
            else
            {
                MessageBox.Show("Nenhum aluno encontrado!");
            }
        }

        private void Txt_NomeAluno_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.Txt_NomeAluno.Text))
            {
                MessageBox.Show("Inforome o Nome do Aluno");
                this.Txt_NomeAluno.Focus();
            }
        }
    }
}
