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
    public partial class FormEquipo : Form
    {
        public FormEquipo()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dsOTCETableAdapters.EquipoTableAdapter ta = new dsOTCETableAdapters.EquipoTableAdapter();
            ta.AddEquipo(txttipo.Text.Trim(), txtmodelo.Text.Trim(), txtserie.Value, txthdd.Text.Trim(), txtehdd.Text.Trim(), txtram1.Value, txtram2.Value, txtcargador.Value, txtbateria.Value, txtobs.Text.Trim(), txtesequipo.Text.Trim(),txtorden.Value);
            this.Close();
        }



        private void FormEquipo_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*dsOTCETableAdapters.EquipoTableAdapter ta = new dsOTCETableAdapters.EquipoTableAdapter();
            ta.UpdateEquipo(txtnumequipo.Value,txttipo.Text.Trim(), txtmodelo.Text.Trim(), txtserie.Value, txthdd.Text.Trim(), txtehdd.Text.Trim(), txtram1.Value, txtram2.Value, txtcargador.Value, txtbateria.Value, txtobs.Text.Trim(), txtesequipo.Text.Trim(), txtorden.Value);
            this.Close();*/
        }


        private void button3_Click(object sender, EventArgs e)
        {
            /*FormBuscarEquipo frm = new FormBuscarEquipo();
            frm.ShowDialog();*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormOrder frm = new FormOrder();
            frm.ShowDialog();
        }
    }
}
