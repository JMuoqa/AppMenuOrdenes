using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesG;
using MySql.Data.MySqlClient;
namespace ConexionDatos
{
    public class ConMenus : Conexion
    {
        public (bool estado, string mensaje) InsertarMenu(Menus menu)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO MenusComida (Nombre, Ingredientes, TipoID, Precio) VALUES(@nombre, @ingredientes, @tipo, @precio)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", menu.NombreMenu);
                        cmd.Parameters.AddWithValue("@ingredientes", menu.IngredientesMenu);
                        cmd.Parameters.AddWithValue("@tipo", menu.TipoMenu);
                        cmd.Parameters.AddWithValue("@precio", menu.PrecioMenu);
                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0)
                            return (true, "Se cargo el Menu correctamente");
                        return (false, "No se pudo cargar el Menu");

                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConMenus -> InsertarMenu(). \n Error: {ex.Message} {menu.TipoMenu}");
                }
            }
        }
    }
}
