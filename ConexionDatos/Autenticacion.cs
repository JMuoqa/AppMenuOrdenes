using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDatos
{
    public class Autenticacion:Conexion
    {
        public bool IniciarSesion(string usuario, string contrasena)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "SELECT * FROM UsuariosMuoqa WHERE Usuario = @user AND Contraseña = @pass";
                    using(MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@user", usuario);
                        cmd.Parameters.AddWithValue("@pass", contrasena);
                        MySqlDataReader lector = cmd.ExecuteReader();
                        if (lector.HasRows)
                        {
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.ToString());
                    return false;
                }

            }
        }
    }
}
