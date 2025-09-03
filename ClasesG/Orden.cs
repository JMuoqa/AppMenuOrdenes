using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesG
{
    public class Orden
    {
        public int IDOrden { get; set; }
        public string NombreCliente { get; set; }
        public string NumeroCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string PrecioTotal { get; set; }
        public string Comentarios { get; set; }
        private string _metodoPago;
        public string MetodoPago 
        { 
            get => _metodoPago; 
            set
            {
                _metodoPago = value.ToLower() == "transferencia" ? "Transferencia" : "Efectivo";
            }
        }
        private string _pago;
        public string Pago
        {
            get => _pago;
            set => _pago = value == "PAGADO" ? "PAGADO" : "NO PAGADO";
        }
        public int ProductosSeleccionados { get; set; }
        private DateTime _horaIngresoPedido;
        public DateTime HoraIngresoPedido
        {
            get => _horaIngresoPedido;
            set
            {
                if (HoraEstimadaEntrega != default && value > HoraEstimadaEntrega)
                    throw new Exception("La hora de ingreso no puede ser posterior a la de entrega.");
                _horaIngresoPedido = value;
            }
        }
        private DateTime _horaEstimadaEntrega;
        public DateTime HoraEstimadaEntrega
        {
            get => _horaEstimadaEntrega;
            set
            {
                if (HoraIngresoPedido != default && value < HoraIngresoPedido)
                    throw new Exception("La hora de entrega no puede ser anterior a la de ingreso.");
                _horaEstimadaEntrega = value;
            }
        }
        public string Estado { get; set; }
        public void ValidarNumero()
        {
            foreach (char c in NumeroCliente)
            {
                int numero;
                bool esNumero = int.TryParse(c.ToString(), out numero);

                if (!esNumero)
                {
                    throw new Exception("El campo 'Número del cliente' contiene caracteres no válidos.");
                }
            }
        }
        public void ValidarEstadoParaBusquedas()
        {
            string[] estadosBusqueda = ["TODOS", "Pendientes", "Confirmadas", "En preparación", "Listas", "Entregadas"];
            string[] estados = ["TODOS", "Pendiente", "Confirmada", "En preparación", "Lista", "Entregada"];
            bool bandera = false;
            for (int i = 0; i < estadosBusqueda.Length; i++)
            {
                if (estadosBusqueda[i] == Estado)
                {
                    Estado = estados[i];
                    bandera = true;
                    break;
                }
            }
            if (!bandera) 
            {
                throw new Exception("El estado seleccionado no existe");
            }
        }
    }
}
