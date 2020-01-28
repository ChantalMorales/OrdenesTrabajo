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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            RefreshCli();
        }

        private void RefreshCli()
        {
            dsOTCETableAdapters.Cliente1TableAdapter ta = new dsOTCETableAdapters.Cliente1TableAdapter();
            dsOTCE.Cliente1DataTable dt = ta.GetDataCli();
            dataGridView1.DataSource = dt;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarCliente frm = new AgregarCliente();
            frm.ShowDialog();
            RefreshCli();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            } 
            catch
            {
                return null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                AgregarCliente frm = new AgregarCliente(Id);
                frm.ShowDialog();
                RefreshCli();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                dsOTCETableAdapters.Cliente1TableAdapter ta = new dsOTCETableAdapters.Cliente1TableAdapter();
                ta.RemoveCli((int)Id);
                RefreshCli();
            }
        }
    }
}
