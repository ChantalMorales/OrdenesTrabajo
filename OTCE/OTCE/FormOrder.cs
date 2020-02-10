using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OTCE
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        /*private void FormOrder_Load(object sender, EventArgs e)
        {
            dsOTCETableAdapters.Estado_OrdenTableAdapter eo = new dsOTCETableAdapters.Estado_OrdenTableAdapter();
            dsOTCE.Estado_OrdenDataTable dt = eo.GetDataByEstado_Orden();
            SqlConnection cn = new SqlConnection("Data Source=ALDEBARAN;Initial Catalog=OrdenesTrabajo;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select estado_orden from Estado_Orden", cn);
            SqlDataReader dr = cm.ExecuteReader();
            cn.Open();
            while (dr.Read())
            {
                cmbEstado.Items.Add(dr.GetString(1));
            }
            cn.Close();
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dsOTCETableAdapters.OrdenTableAdapter ta = 
                new dsOTCETableAdapters.OrdenTableAdapter();
            
            this.Close();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void FormOrder_Load_1(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=ALDEBARAN;Initial Catalog=OrdenesTrabajo;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select estado_orden from Estado_Orden", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            
            while (dr.Read())
            {
                cmbEstado.Items.Add(dr.GetString(0));
            }
            cn.Close();

            SqlConnection cnp = new SqlConnection("Data Source=ALDEBARAN;Initial Catalog=OrdenesTrabajo;Integrated Security=True");
            SqlCommand cmp = new SqlCommand("select desc_prioridad from Prioridad", cnp);
            cnp.Open();
            SqlDataReader drp = cmp.ExecuteReader();

            while (drp.Read())
            {
                cmbPrioridad.Items.Add(drp.GetString(0));
            }
            cnp.Close();

            SqlConnection cnc = new SqlConnection("Data Source=ALDEBARAN;Initial Catalog=OrdenesTrabajo;Integrated Security=True");
            SqlCommand cmc = new SqlCommand("select nombre from Cliente", cnc);
            cnc.Open();
            SqlDataReader drc = cmc.ExecuteReader();

            while (drc.Read())
            {
                cmbClient.Items.Add(drc.GetString(0));
            }
            cnc.Close();
        }
    }
}
