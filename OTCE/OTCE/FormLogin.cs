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
    public partial class FormLogin : Form
    {
        Principal vistas;
        public FormLogin()
        {
            InitializeComponent();
        }

       

        private void btiniciarsesion_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost;Initial Catalog=OrdenesTrabajo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select nombre_usuario, contrasena from usuario where nombre_usuario=@UserName and contrasena=@Password", sqlcon);
            cmd.Parameters.AddWithValue("@UserName", txtName.Text);
            cmd.Parameters.AddWithValue("@Password", txtpasswd.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            sqlcon.Open();
            int i = cmd.ExecuteNonQuery();
            sqlcon.Close();
            if (dtbl.Rows.Count == 1)
            {
                vistas = new Principal();
                vistas.Show();
                

            }
            else
            {
                MessageBox.Show("verifica tu usuario o contraseña");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
