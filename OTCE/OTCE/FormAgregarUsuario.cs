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
    public partial class FormAgregarUsuario : Form
    {
        private  int? Id;
        public FormAgregarUsuario(int? Id=null)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsOTCETableAdapters.UsuarioTableAdapter ta = new dsOTCETableAdapters.UsuarioTableAdapter();
            if (Id == null)
            {
                ta.Add(txtName.Text.Trim(), txtPasswd.Text, txtRol.Text.Trim());
            }
            else
            {
                ta.Edit(txtName.Text.Trim(), txtPasswd.Text, txtRol.Text.Trim(),(int)Id);
            }
            this.Close();
        }

        private void FormAgregarUsuario_Load(object sender, EventArgs e)
        {
            if(Id!=null)
            {
                dsOTCETableAdapters.UsuarioTableAdapter ta = new dsOTCETableAdapters.UsuarioTableAdapter();
                dsOTCE.UsuarioDataTable dt= ta.GetDataById((int)Id);
                dsOTCE.UsuarioRow row = (dsOTCE.UsuarioRow)dt.Rows[0];
                txtName.Text = row.nombre_usuario;
                txtPasswd.Text = row.contrasena;
                txtRol.Text = row.rol;

            }
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
