using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTCE
{
    public partial class FormEquipo : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=OrdenesTrabajo;Integrated Security=True");
        public FormEquipo()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dsOTCETableAdapters.EquipoTableAdapter ta = new dsOTCETableAdapters.EquipoTableAdapter();
            ta.AddEquipo(txttipo.Text.Trim(), txtmodelo.Text.Trim(), txthdd.Text.Trim(), txtehdd.Text.Trim(), txtobs.Text.Trim(), txtesequipo.SelectedItem.ToString(), Decimal.Parse(cmborden.SelectedItem.ToString()), txtserie.Text.Trim(),  txtram1.Text.Trim(), txtram2.Text.Trim(), txtcargador.Text.Trim(), txtbateria.Text.Trim());
            this.Close();
        }



        private void FormEquipo_Load(object sender, EventArgs e)
        {

            txtesequipo.Items.Add("ENCENDIDO");
            txtesequipo.Items.Add("APAGADO");

            SqlCommand comando = new SqlCommand("SELECT id_orden_FK FROM Equipo", conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cmborden.Items.Add(registro["id_orden_FK"].ToString());
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*dsOTCETableAdapters.EquipoTableAdapter ta = new dsOTCETableAdapters.EquipoTableAdapter();
            ta.UpdateEquipo(txtnumequipo.Value,txttipo.Text.Trim(), txtmodelo.Text.Trim(), txtserie.Value, txthdd.Text.Trim(), txtehdd.Text.Trim(), txtram1.Value, txtram2.Value, txtcargador.Value, txtbateria.Value, txtobs.Text.Trim(), txtesequipo.Text.Trim(), txtorden.Value);
            this.Close();*/
        }


        private void button3_Click(object sender, EventArgs e)
        {
            FormBuscarEquipo frm = new FormBuscarEquipo();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormOrder frm = new FormOrder();
            frm.ShowDialog();
        }

        private void txtesequipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
