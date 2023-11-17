using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void btn_Moeda_Click(object sender, EventArgs e)
        {
            mask_Conteudo.UseSystemPasswordChar = false;
            changeMask("$ 000,000,000,000.00");
        }

        private void btn_Data_Click(object sender, EventArgs e)
        {
            mask_Conteudo.UseSystemPasswordChar = false;
            changeMask("00/00/0000");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Hora_Click(object sender, EventArgs e)
        {
            mask_Conteudo.UseSystemPasswordChar = false;
            changeMask("00:00");
        }

        private void btn_CEP_Click(object sender, EventArgs e)
        {
            mask_Conteudo.UseSystemPasswordChar = false;
            changeMask("00000-000");
        }

        private void btn_Senha_Click(object sender, EventArgs e)
        {
            mask_Conteudo.UseSystemPasswordChar = true;
        }

        private void changeMask(string mascara)
        {
            lbl_Conteudo.Text = "";
            mask_Conteudo.Text = "";
            mask_Conteudo.Mask = mascara;
            lbl_MascaraAtiva.Text = mask_Conteudo.Mask;
            mask_Conteudo.Focus();
        }

        private void btn_VerConteudo_Click(object sender, EventArgs e)
        {
            lbl_Conteudo.Text = mask_Conteudo.Text;
        }

        private void btn_Telefone_Click(object sender, EventArgs e)
        {
            mask_Conteudo.UseSystemPasswordChar = false;
            changeMask("+55 (00) 00000-0000");
        }
    }
}
