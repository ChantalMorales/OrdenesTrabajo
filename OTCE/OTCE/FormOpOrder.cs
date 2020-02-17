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
    public partial class FormOpOrder : Form
    {
        public FormOpOrder()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RefreshOrder()
        {
            dsOTCETableAdapters.OrdenTableAdapter ta = new dsOTCETableAdapters.OrdenTableAdapter();
            dsOTCE.OrdenDataTable dt = ta.GetData();
            dataGridView1.DataSource = dt;
        }

        private void FormOpOrder_Load(object sender, EventArgs e)
        {
            RefreshOrder();
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                FormOrder frm = new FormOrder(Id);
                frm.ShowDialog();
                RefreshOrder();
                this.Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Principal frm = new Principal();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshOrder();
        }
    }
}
