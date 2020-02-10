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
            dsOTCETableAdapters.OrdenTableAdapter ta =
                new dsOTCETableAdapters.OrdenTableAdapter();
            dsOTCE.OrdenDataTable dt = ta.GetDataOrder();
            dataGridView1.DataSource = dt;
        }

        private void FormOpOrder_Load(object sender, EventArgs e)
        {
            RefreshOrder();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormOrder frm = new FormOrder();
            frm.ShowDialog();
        }
    }
}
