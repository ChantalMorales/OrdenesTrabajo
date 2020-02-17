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
    public partial class AgregarCliente : Form
    {
        private int? Id;
        public AgregarCliente(int? Id=null)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsOTCETableAdapters.Cliente1TableAdapter ta = new dsOTCETableAdapters.Cliente1TableAdapter();
            if (Id == null)
            {
                ta.AddCliente(txtNameCli.Text, txtTelf.Text, txtDir.Text, txtEmail.Text, txtCI.Text);
            }
            else
            {
                ta.EditCliente(txtNameCli.Text, txtTelf.Text, txtDir.Text, txtEmail.Text, txtCI.Text, (int)Id);
            }
            this.Close();

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            if(Id !=null)
            {
                dsOTCETableAdapters.Cliente1TableAdapter ta = new dsOTCETableAdapters.Cliente1TableAdapter();
                dsOTCE.Cliente1DataTable dt= ta.GetDataCliById((int)Id);
                dsOTCE.Cliente1Row row = (dsOTCE.Cliente1Row)dt.Rows[0];
                txtNameCli.Text = row.nombre;
                txtTelf.Text = row.telefono;
                txtDir.Text = row.direccion;
                txtEmail.Text = row.correo;
                txtCI.Text = row.ci;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOrder frm = new FormOrder();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormOrder frm = new FormOrder();
            frm.ShowDialog();
        }
    }
}
