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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

       

        private void btiniciarsesion_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbnombre.Text)&& !String.IsNullOrEmpty(tbcontrasena.Text))
            {
                try 
                {
                    BaseDatos bd =new  BaseDatos();
                    Boolean res = bd.iniciarSesion(tbnombre.Text, tbcontrasena.Text);
                    if (res)
                    {
                        Principal p = new Principal();
                        p.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Complete los Datos");
            }
        }
    }
}
