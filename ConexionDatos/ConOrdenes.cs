using ClasesG;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDatos
{
    public class ConOrdenes:Conexion
    {
        public (bool estado, string mensaje) InsertarOrden(List<DetallesDeLosPedidos> listaDetalles, Orden orden)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    int precioTotal = 0;
                    for(int i = 0; i<listaDetalles.Count; i++)
                    {
                        precioTotal += int.Parse(listaDetalles[i].Precio.Replace("$", ""));
                    }
                    string precioFinal = "$"+precioTotal.ToString();
                    int ultimoID;
                    string insertarOrden = "INSERT INTO Orden (NombreDelCliente, TelefonoDelCliente, DireccionDelCliente, PrecioTotal, Estado, HoraIngresoPedido, HoraEstimadaEntrega) VALUES(@nombre, @tel, @dire, @precio, @estado, @ingreso, @entrega);";
                    using(MySqlCommand cmd = new MySqlCommand(insertarOrden, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", orden.NombreCliente);
                        cmd.Parameters.AddWithValue("@tel", orden.NumeroCliente);
                        cmd.Parameters.AddWithValue("@dire", orden.DireccionCliente);
                        cmd.Parameters.AddWithValue("@precio", precioFinal);
                        cmd.Parameters.AddWithValue("@estado", orden.Estado);
                        cmd.Parameters.AddWithValue("@ingreso", orden.HoraIngresoPedido);
                        cmd.Parameters.AddWithValue("@entrega", orden.HoraEstimadaEntrega);
                        int fila = cmd.ExecuteNonQuery();
                        if (fila == 0)
                            return (false, "No se pudieron cargar los datos");
                        cmd.CommandText = "SELECT LAST_INSERT_ID();";// Es para obtener el id.
                        object result = cmd.ExecuteScalar(); // Devuelve un object
                        ultimoID = Convert.ToInt32(result);
                    }
                    for (int i = 0; i < listaDetalles.Count; i++)
                    {
                        DetallesDeLosPedidos detalles = listaDetalles[i];
                        detalles.IDOrden = ultimoID;
                        string insertarDetalles = "INSERT INTO DetallesDeLosPedidos (IDOrden, IDMenu, NombreMenu, Cantidad, Precio, Activo) VALUES(@orden, @menu, @nombremenu, @cantidad, @precio, @activo)";
                        using (MySqlCommand cmd = new MySqlCommand(insertarDetalles, con)) 
                        {
                            cmd.Parameters.AddWithValue("@orden", detalles.IDOrden);
                            cmd.Parameters.AddWithValue("@menu", detalles.IDMenu);
                            cmd.Parameters.AddWithValue("@nombremenu", detalles.NombreMenu);
                            cmd.Parameters.AddWithValue("@cantidad", detalles.Cantidad);
                            cmd.Parameters.AddWithValue("@precio", detalles.Precio);
                            cmd.Parameters.AddWithValue("@activo", "si");
                            int fila = cmd.ExecuteNonQuery();
                            if (fila == 0)
                                return (false, "No se pudieron cargar los datos");
                        }
                    }
                    return (true, "La orden se cargo correctamente");
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConOrdenes -> InsertarOrden(). \n Error: {ex.Message}");
                }
            }
        }
    }
}
