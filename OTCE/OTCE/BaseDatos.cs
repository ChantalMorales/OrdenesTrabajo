using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace OTCE
{
    class BaseDatos
    {
        private string cadenaConexion = "Data Source= CHANTALM; Initial Catalog=OrdenesTrabajo; Integrated Security=true;";

        public static string nombreCompleto = "";
        public static string rol = "";
        public Boolean iniciarSesion(string nomus, string con)
        {

            nombreCompleto = "";
            rol = "";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlParameter parnomus = new SqlParameter("@nomus", nomus);
            SqlParameter parcon = new SqlParameter("@con", con);

            SqlCommand comando = new SqlCommand("SELECT nombre_usuario,rol FROM Usuario where nombre_usuario=@nomus and contrasena COLLATE Latin_General_CS_AS= @con", conexion);
            comando.Parameters.Add(parnomus);
            comando.Parameters.Add(parcon);

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                nombreCompleto = lector.GetString(0);
                rol = lector.GetString(1);
            }
            lector.Close();
            conexion.Close();
            if (String.IsNullOrEmpty(rol))
            {
                return false;
            }
            else
            {
                return true; 
            }
        }
    }
}
