using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDatos
{
    public class Tipos:Conexion
    {
        public (bool estado, string mensaje) InsertarTipo(string tipo)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO TiposDeMenu (Tipo) VALUES(@tipo);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                            return (true, "Se cargo el tipo correctamente");
                        return (false, "No se pudo cargar el Tipo");
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> Tipos -> InsertarTipo(). \n Error: {ex.Message}");
                }
            }
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerTipos()
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    DataTable datosObtenidos = new DataTable();
                    string sql = "SELECT * FROM TiposDeMenu ORDER BY ID ASC;";
                    using (MySqlDataAdapter datosMySql = new MySqlDataAdapter(sql, con))
                    {
                        datosMySql.Fill(datosObtenidos);
                    }
                    if(datosObtenidos.Rows.Count == 0)
                        return(false,"No hay datos cargados. Tienes que agregar tipos.", new DataTable());
                    return (true, "Exitosa", datosObtenidos);
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> Tipos -> ObtenerTipos(). \n Error: {ex.Message}", new DataTable());
                }
            }
        }
    }
}
