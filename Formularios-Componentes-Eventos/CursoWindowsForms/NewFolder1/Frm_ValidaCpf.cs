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
    public partial class Frm_ValidaCpf : Form
    {
        public Frm_ValidaCpf()
        {
            InitializeComponent();
        }
        public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void mask_Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
 
        }

        private void btn_Validar_Click(object sender, EventArgs e)
        {
            bool validadeCpf = Valida(mask_Cpf.Text);

            var result = MessageBox.Show($"Deseja mesmo validar o cpf: {mask_Cpf.Text}?", "Confirmação de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (validadeCpf)
                {
                    MessageBox.Show("CPF VÁLIDO", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF INVALIDO", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                mask_Cpf.Text = "";
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
      
            mask_Cpf.Text = "";
        }

        private void lbl_TituloValidadorCPF_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ValidaCpf_Load(object sender, EventArgs e)
        {

        }
    }
}
