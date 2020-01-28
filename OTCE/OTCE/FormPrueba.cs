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
    public partial class FormPrueba : Form
    {
        public FormPrueba()
        {
            InitializeComponent();
        }

        private void FormPrueba_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            dsOTCETableAdapters.UsuarioTableAdapter ta = new dsOTCETableAdapters.UsuarioTableAdapter();
            dsOTCE.UsuarioDataTable dt = ta.GetData();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario frm = new FormAgregarUsuario();
            frm.ShowDialog();
            Refresh();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            } catch
            {
                return null;
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if(Id!=null)
            {
                FormAgregarUsuario frm = new FormAgregarUsuario(Id);
                frm.ShowDialog();
                Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                dsOTCETableAdapters.UsuarioTableAdapter ta = new dsOTCETableAdapters.UsuarioTableAdapter();
                ta.Remove((int)Id);
                Refresh();
            }
        }
    }
}
