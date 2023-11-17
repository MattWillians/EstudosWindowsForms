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
    public partial class Frm_MouseEventos : Form
    {
        public Frm_MouseEventos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Mouse_MouseEnter(object sender, EventArgs e)
        {
            Btn_Mouse.Text = "Mouse Entrou";
        }

        private void Btn_Mouse_MouseLeave(object sender, EventArgs e)
        {
            Btn_Mouse.Text = "Mouse Saiu";
        }

        private void Btn_Mouse_MouseHover(object sender, EventArgs e)
        {
            Btn_Mouse.Text = "Mouse Hoverou";
        }
    }
}
