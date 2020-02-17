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
        private int? Id;
        public FormOrder(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dsOTCETableAdapters.OrdenTableAdapter ta = new dsOTCETableAdapters.OrdenTableAdapter();
            ta.AddOrder(txtObFinal.Text.Trim(), txtDiagnostic.Text.Trim(), txtObFinal.Text.Trim(), cmbEstado.SelectedItem.ToString(),
                cmbPrioridad.SelectedItem.ToString(), cmbTech.SelectedItem.ToString(), txtClient.Text.Trim(), txtDtEntry.Text.Trim(),
                txtDtOut.Text.Trim());
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dsOTCETableAdapters.OrdenTableAdapter ta = new dsOTCETableAdapters.OrdenTableAdapter();
            if (Id == null)
            {
                ta.AddOrder(txtObinicial.Text.Trim(), txtDiagnostic.Text.Trim(), txtObFinal.Text.Trim(), cmbEstado.SelectedItem.ToString(),
                cmbPrioridad.SelectedItem.ToString(), cmbTech.SelectedItem.ToString(), txtClient.Text.Trim(), txtDtEntry.Text.Trim(),
                txtDtOut.Text.Trim());
            }
            else
            {
                ta.EditOrder(txtObinicial.Text.Trim(), txtDiagnostic.Text.Trim(), txtObFinal.Text.Trim(), cmbEstado.SelectedItem.ToString(),
                cmbPrioridad.SelectedItem.ToString(), cmbTech.SelectedItem.ToString(), txtClient.Text.Trim(), txtDtEntry.Text.Trim(),
                txtDtOut.Text.Trim(), (int)Id);
            }
            this.Close();
        }

        private void FormOrder_Load_1(object sender, EventArgs e)
        {
            if (Id != null)
            {
                dsOTCETableAdapters.OrdenTableAdapter ta = new dsOTCETableAdapters.OrdenTableAdapter();
                dsOTCE.OrdenDataTable dt = ta.GetDataByIdOrder((int)Id);
                dsOTCE.OrdenRow row = (dsOTCE.OrdenRow)dt.Rows[0];
                txtObinicial.Text = row.observacionesrecibido;
                txtDiagnostic.Text = row.diagnostico;
                txtObFinal.Text = row.observacionesfinal;
                cmbEstado.SelectedItem = row.estado_order_FK;
                cmbPrioridad.SelectedItem = row.prioridad_or;
                cmbTech.SelectedItem = row.nombre_us;
                txtClient.Text = row.cliente_FK;
                txtDtEntry.Text = row.fecha_ingreso;
                txtDtOut.Text = row.fecha_salida;
            }

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

            SqlConnection cnu = new SqlConnection("Data Source=ALDEBARAN;Initial Catalog=OrdenesTrabajo;Integrated Security=True");
            SqlCommand cmu = new SqlCommand("select nombre_usuario from Usuario", cnu);
            cnu.Open();
            SqlDataReader dru = cmu.ExecuteReader();

            while (dru.Read())
            {
                cmbTech.Items.Add(dru.GetString(0));
            }
            cnu.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEquipo frm = new FormEquipo();
            frm.ShowDialog();
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
