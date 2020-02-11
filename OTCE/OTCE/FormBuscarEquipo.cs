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
    public partial class FormBuscarEquipo : Form
    {
        public FormBuscarEquipo()
        {
            InitializeComponent();
        }

        private void FormBuscarEquipo_Load(object sender, EventArgs e)
        {
            RefreshEquipo();
        }

        private void RefreshEquipo()
        {
            dsOTCETableAdapters.Equipo1TableAdapter ta = new dsOTCETableAdapters.Equipo1TableAdapter();
            dsOTCE.Equipo1DataTable dt = ta.GetData();
            dataGridView1.DataSource = dt;
        }
    }
}
