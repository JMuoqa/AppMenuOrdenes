using ClasesG;
using ConexionDatos;
using System;
using System.Collections.Generic;
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
            return conOrdenes.InsertarOrden(listaDetalles, orden);
        }
    }
}
