using ConexionDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DTipos
    {
        Tipos agregarTipos = new Tipos();
        public (bool estado, string mensaje) InsertarTipo(string tipo)
        {
            return agregarTipos.InsertarTipo(tipo);
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerDatos()
        {
            return agregarTipos.ObtenerTipos();
        }
    }
}
