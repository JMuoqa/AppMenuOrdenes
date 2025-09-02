using ClasesG;
using ConexionDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class D_ConOrdenes
    {
        ConOrdenes conOrdenes = new ConOrdenes();
        public (bool estado, string mensaje) InsertarOrden(List<DetallesDeLosPedidos> listaDetalles, Orden orden)
        {
            try
            {
                orden.ValidarNumero();
                return conOrdenes.InsertarOrden(listaDetalles, orden);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerOrdenPorID(int id)
        {
            return conOrdenes.ObtenerOrdenPorID(id);
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerOrdenPorNombre(string nombre)
        {
            return conOrdenes.ObtenerOrdenPorNombre(nombre);
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerOrdenPorTelefono(string telefono)
        {
            return conOrdenes.ObtenerOrdenPorTelefono(telefono);
        }
        public (bool estado, string mensaje, DataTable datos) ObtenerDetalles(int id)
        {
            return conOrdenes.ObtenerDetalles(id);
        }
        public (bool estado, string mensaje) ModificarOrden(List<DetallesDeLosPedidos> listaDetalles, Orden orden)
        {
            return conOrdenes.ModificarOrden(listaDetalles, orden);
        }
    }
}
