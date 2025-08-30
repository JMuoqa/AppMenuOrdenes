using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
                    return (false, $"Error grave | ConexionDatos -> ConMenus -> InsertarMenu(). \n Error: {ex.Message}");
                }
            }
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerMenusPorID(int ID)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    DataTable datosObtenidos = new DataTable();
                    string sql = "SELECT * FROM MenusComida WHERE ID = @id ORDER BY ID ASC;"; // MySqlDataAdapter no tiene para añadir parametros
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        using (MySqlDataAdapter datosMySql = new MySqlDataAdapter(cmd))
                        {
                            datosMySql.Fill(datosObtenidos);
                        }
                    }
                    if (datosObtenidos.Rows.Count == 0)
                        return (false, "No hay datos cargados. Tienes que agregar tipos.", new DataTable());
                    return (true, "Exitosa", datosObtenidos);
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConMenus -> ObtenerMenus(). \n Error: {ex.Message}", new DataTable());
                }
            }
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerMenusPorNombre(string nombre)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    DataTable datosObtenidos = new DataTable();
                    string sql = "SELECT * FROM MenusComida WHERE Nombre LIKE @nombre ORDER BY ID ASC;"; // MySqlDataAdapter no tiene para añadir parametros
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                        using (MySqlDataAdapter datosMySql = new MySqlDataAdapter(cmd))
                        {
                            datosMySql.Fill(datosObtenidos);
                        }
                    }
                    if (datosObtenidos.Rows.Count == 0)
                        return (false, "No hay datos cargados. Tienes que agregar tipos.", new DataTable());
                    return (true, "Exitosa", datosObtenidos);
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConMenus -> ObtenerMenus(). \n Error: {ex.Message}", new DataTable());
                }
            }
        }
        public (bool estado, string mensaje) ModificarMenu(Menus menu)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "UPDATE MenusComida SET Nombre = @nombre, Ingredientes = @ingredientes, TipoID = @tipoid, Precio = @precio WHERE ID = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", menu.NombreMenu);
                        cmd.Parameters.AddWithValue("@ingredientes", menu.IngredientesMenu);
                        cmd.Parameters.AddWithValue("@tipoid", menu.TipoMenu);
                        cmd.Parameters.AddWithValue("@precio", menu.PrecioMenu);
                        cmd.Parameters.AddWithValue("@id", menu.IDMenu);
                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0)
                            return (true, "Se guardaron los cambios correctamente");
                        return (false, "No se guardaron los cambios correctamente");
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConMenus -> ObtenerMenus(). \n Error: {ex.Message}");
                }
            } 
        }
    }
}
