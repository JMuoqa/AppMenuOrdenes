using System;
using MySql.Data.MySqlClient;
namespace ConexionDatos
{
    public abstract class Conexion
    {
        // Cadena de conexión
        private readonly string cadenaDeConexion;
        public Conexion()
        {
            cadenaDeConexion = "server=localhost;database=muoqaappcomida_uno;user=root;password=MyLH#1986J;";
        }
        protected MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaDeConexion);
        }
    }
}