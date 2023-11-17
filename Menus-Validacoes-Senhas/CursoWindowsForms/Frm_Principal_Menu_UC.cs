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
    public partial class Frm_Principal_Menu_UC : Form
    {

        int ControleHelloWorld = 0;
        int ControleDemostracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaSenha = 0;
        int ControleValidaCPF2 = 0;
        int ControleArquivoImagem = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;

        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;
            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCPF;
            TB.Text = "Valída CPF " + ControleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemostracaoKey += 1;
            Frm_DemostracaoKey_UC U = new Frm_DemostracaoKey_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Demostração Key " + ControleDemostracaoKey;
            TB.Text = "Demostração Key " + ControleDemostracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Hello World " + ControleHelloWorld;
            TB.Text = "Hello World " + ControleHelloWorld;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            Frm_Mascara_UC U = new Frm_Mascara_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Máscara " + ControleMascara;
            TB.Text = "Máscara " + ControleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF2 " + ControleValidaCPF2;
            TB.Text = "Valída CPF2 " + ControleValidaCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida Senha " + ControleValidaSenha;
            TB.Text = "Valída Senha " + ControleValidaSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\WindowsForms\\Curso\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a Imagem";

            if(Db.ShowDialog() == DialogResult.OK)
            {

                string nomeArquivoImagem = Db.FileName;

                ControleArquivoImagem += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Arquivo Imagem " + ControleArquivoImagem;
                TB.Text = "Arquivo Imagem " + ControleArquivoImagem;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }

           
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {

                string senha = F.senha;
                string login = F.login;

                if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + login + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Db = new Frm_Questao("icons8_question_mark_961", "Você deseja se desconectar ?");
            Db.ShowDialog();
            //if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            if (Db.DialogResult == DialogResult.Yes)
            {

                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                for (int i= Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i+=-1)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
            }
         
        }
    }
}
