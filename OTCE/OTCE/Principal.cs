using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTCE
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrueba frm = new FormPrueba();
            frm.ShowDialog();
            Refresh();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClientes frm = new FormClientes();
            frm.ShowDialog();
            
        }
    }
}
