using ClasesG;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                    string insertarOrden = "INSERT INTO Orden (NombreDelCliente, TelefonoDelCliente, DireccionDelCliente, PrecioTotal, Estado, Comentarios, MetodoDePago, Pago, ProductosSeleccionados, HoraIngresoPedido, HoraEstimadaEntrega) VALUES(@nombre, @tel, @dire, @precio, @estado, @comentarios, @metodo,@pago,@seleccionados, @ingreso, @entrega);";
                    using(MySqlCommand cmd = new MySqlCommand(insertarOrden, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", orden.NombreCliente);
                        cmd.Parameters.AddWithValue("@tel", orden.NumeroCliente);
                        cmd.Parameters.AddWithValue("@dire", orden.DireccionCliente);
                        cmd.Parameters.AddWithValue("@precio", precioFinal);
                        cmd.Parameters.AddWithValue("@estado", orden.Estado);
                        cmd.Parameters.AddWithValue("@comentarios", orden.Comentarios);
                        cmd.Parameters.AddWithValue("@metodo", orden.MetodoPago);
                        cmd.Parameters.AddWithValue("@pago", orden.Pago);
                        cmd.Parameters.AddWithValue("@seleccionados", orden.ProductosSeleccionados);
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
        public (bool estado, string mensaje, DataTable datos) ObtenerOrdenesPorEstado(Orden orden)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    DataTable dataTable = new DataTable();
                    string sql;
                    if(orden.Estado == "TODOS")
                        sql = "SELECT * FROM Orden";
                    else
                        sql = "SELECT * FROM Orden WHERE Estado = @estado";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@estado", orden.Estado);
                        using (MySqlDataAdapter datosMySql = new MySqlDataAdapter(cmd))
                        {
                            datosMySql.Fill(dataTable);
                        }
                        if (dataTable.Rows.Count == 0)
                            return (false, "No hay datos cargados. Tienes que agregar ordenes.", new DataTable());
                        return (true, "Exitosa", dataTable);
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConOrdenes -> ObtenerOrdenesPorEstado(). \n Error: {ex.Message}", new DataTable());
                }
            }
        } 
        public (bool estado, string mensaje, DataTable datos) ObtenerOrdenPorID(int ID)
        {
            using(MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    DataTable datosObtenidos = new DataTable();
                    string sql = "SELECT * FROM Orden WHERE IDOrden = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        using (MySqlDataAdapter datosMySql = new MySqlDataAdapter(cmd))
                        {
                            datosMySql.Fill(datosObtenidos);
                        }
                        if (datosObtenidos.Rows.Count == 0)
                            return (false, "No hay datos cargados. Tienes que agregar ordenes.", new DataTable());
                        return (true, "Exitosa", datosObtenidos);
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConOrdenes -> ObtenerOrdenPorID(). \n Error: {ex.Message}", new DataTable());
                }
            }
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerOrdenPorNombre(string nombre)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    DataTable datosObtenidos = new DataTable();
                    string sql = "SELECT * FROM Orden WHERE NombreDelCliente LIKE @nombre";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                        using (MySqlDataAdapter datosMySql = new MySqlDataAdapter(cmd))
                        {
                            datosMySql.Fill(datosObtenidos);
                        }
                        if (datosObtenidos.Rows.Count == 0)
                            return (false, "No hay datos cargados. Tienes que agregar ordenes.", new DataTable());
                        return (true, "Exitosa", datosObtenidos);
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConOrdenes -> ObtenerOrdenPorNombre(). \n Error: {ex.Message}", new DataTable());
                }
            }
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerOrdenPorTelefono(string telefono)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    DataTable datosObtenidos = new DataTable();
                    string sql = "SELECT * FROM Orden WHERE TelefonoDelCliente = @telefono";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        using (MySqlDataAdapter datosMySql = new MySqlDataAdapter(cmd))
                        {
                            datosMySql.Fill(datosObtenidos);
                        }
                        if (datosObtenidos.Rows.Count == 0)
                            return (false, "No hay datos cargados. Tienes que agregar ordenes.", new DataTable());
                        return (true, "Exitosa", datosObtenidos);
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConOrdenes -> ObtenerOrdenPorTelefono(). \n Error: {ex.Message}", new DataTable());
                }
            }
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerDetalles(int idDetalles)
        {
            using (MySqlConnection conn = ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    DataTable datosObtenidos = new DataTable();
                    string sql = "SELECT * FROM DetallesDeLosPedidos WHERE IDOrden = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idDetalles);
                        using (MySqlDataAdapter datosMySql = new MySqlDataAdapter(cmd))
                        {
                            datosMySql.Fill(datosObtenidos);
                        }
                    }
                    if (datosObtenidos.Rows.Count == 0)
                        return (false, "No se encontraron detalles.", new DataTable());
                    return (true, "Exitosa", datosObtenidos);
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConOrdenes -> ObtenerConexion(). \n Error: {ex.Message}", new DataTable());
                }
            }
        }
        public (bool estado, string mensaje) ModificarOrden(List<DetallesDeLosPedidos> listaDetalles, Orden orden) 
        {
            using (MySqlConnection con = ObtenerConexion()) 
            {
                try
                {
                    con.Open(); 
                    int precioTotal = 0;
                    for (int i = 0; i < listaDetalles.Count; i++)
                    {
                        precioTotal += int.Parse(listaDetalles[i].Precio.Replace("$", ""));
                    }
                    string precioFinal = "$" + precioTotal.ToString();
                    string sql = "UPDATE Orden SET NombreDelCliente = @nombre, TelefonoDelCliente = @tel, DireccionDelCliente = @dire, PrecioTotal = @precio, Estado = @estado, Comentarios = @comentarios, MetodoDePago = @metodo, Pago = @pago, ProductosSeleccionados = @seleccionados, HoraIngresoPedido = @ingreso, HoraEstimadaEntrega = @entrega WHERE IDOrden = @id;";
                    int filas;
                    using (MySqlCommand cmd = new MySqlCommand(sql, con)) 
                    {
                        cmd.Parameters.AddWithValue("@id", orden.IDOrden);
                        cmd.Parameters.AddWithValue("@nombre", orden.NombreCliente);
                        cmd.Parameters.AddWithValue("@tel", orden.NumeroCliente);
                        cmd.Parameters.AddWithValue("@dire", orden.DireccionCliente);
                        cmd.Parameters.AddWithValue("@precio", precioFinal);
                        cmd.Parameters.AddWithValue("@estado", orden.Estado);
                        cmd.Parameters.AddWithValue("@comentarios", orden.Comentarios);
                        cmd.Parameters.AddWithValue("@metodo", orden.MetodoPago);
                        cmd.Parameters.AddWithValue("@pago", orden.Pago);
                        cmd.Parameters.AddWithValue("@seleccionados", orden.ProductosSeleccionados);
                        cmd.Parameters.AddWithValue("@ingreso", orden.HoraIngresoPedido);
                        cmd.Parameters.AddWithValue("@entrega", orden.HoraEstimadaEntrega);
                        filas = cmd.ExecuteNonQuery();
                    }
                    if (filas == 0)
                        return (false, "No se encontro esa orden");
                    bool detallesCambiados = true;
                    bool detallesInsertos = true;
                    for(int i = 0; i < listaDetalles.Count; i++)
                    {
                        DetallesDeLosPedidos detalles = listaDetalles[i];
                        detalles.IDOrden = orden.IDOrden;
                        bool bandera = false;
                        string verSiExiste = "SELECT IDMenu FROM DetallesDeLosPedidos WHERE IDMenu = @id";
                        using (MySqlCommand cmd = new MySqlCommand(verSiExiste, con))
                        {
                            cmd.Parameters.AddWithValue("@id", detalles.IDMenu);
                            //Se usa ExecuteScalar() por que el ExecuteNonQuery Solo devuelve filas afectadas mientras la consulta sea un INSERT UPDATE O DELETE
                            object result = cmd.ExecuteScalar();// cmd.ExecuteScalar() devuelve la primer columna de la primer fila seleccionada
                            if (result != null) // Si encontró algo
                                bandera = true;
                        }
                        if (bandera) //Si badenra es true signidica que ya hay un menu igual en el pedido
                        {
                            string modificarMenu = "UPDATE DetallesDeLosPedidos SET Cantidad = @cantidad, Precio = @precio WHERE IDMenu = @id";
                            using (MySqlCommand cmd = new MySqlCommand(modificarMenu, con)) 
                            {
                                cmd.Parameters.AddWithValue("@cantidad", detalles.Cantidad);
                                cmd.Parameters.AddWithValue("@precio", detalles.Precio);
                                cmd.Parameters.AddWithValue("@id", detalles.IDMenu);
                                int modifica = cmd.ExecuteNonQuery();
                                if (modifica == 0) // Si no cambio nada, tiraremos un error luego
                                    detallesCambiados = false;
                            }
                        }
                        else
                        {
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
                                if (fila == 0) //Si no se inserto nada, lanzaremos un error luego
                                    detallesInsertos = false;
                            }
                        }
                        if (!detallesCambiados && !detallesInsertos)
                            throw new Exception($"Hubo un error. Saca captura y contactate con el desarrollador. {detalles.IDMenu}");
                    }
                    return (true, "Se modifico la orden exitosamente");
                }
                catch (Exception ex)
                {
                    return (false, $"Error grave | ConexionDatos -> ConOrdenes -> ModificarOrden(). \n Error: {ex.Message} ");
                }
            }

        }
    }
}
