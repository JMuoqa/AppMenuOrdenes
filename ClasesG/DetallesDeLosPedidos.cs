using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesG
{
    public class DetallesDeLosPedidos
    {
        public int IDDPedidos { get; set; } // Lo de arriba es un comentario de aprendizaje
        public int IDOrden { get; set; }
        public int IDMenu { get; set; }
        public string NombreMenu { get; set; }
        private int _cantidad;
        public int Cantidad
        {
            get => _cantidad;
            set
            {
                if (value < 0) throw new Exception("La cantidad de pedidos no puede ser menor a 0");
                else _cantidad = value;
            }
        }
        public string Precio { get; set; }
        private string _activo;
        public string Activo
        {
            get => _activo;
            set
            {
                _activo = value == "si" ? "si" : "no";
            }
        }
    }
}

/* EXPLICACION DE GET SET
    Si no tuvieras el campo privado (_IDPedidos) y pusieras IDPedidos = value;, 
    entrarías en un bucle infinito porque el set estaría llamando al mismo set otra vez.get
    Esto esta MAL:
    public int IDPedidos { 
        get
        {
            return IDPedidos; // MAL
        }
        set 
        { 
            if(value < 0) throw new Exception("El id no puede ser negativo");
            IDPedidos = value; // MAL SE CREA UN CICLO INFINITO
        }
    }
private int _IDPedidos;
public int IDPedidos //IDPedidos no es una variable independiente, es una propiedad que actúa como una "capa de acceso" a la variable privada _IDPedidos.
{ 

    get => _IDPedidos; // cuando lees DetallesDeLosPedidos.IDPedidos devuelve _IDPedidos
    set 
    { if(value < 0) throw new Exception("El id no puede ser negativo");// Antes de asignas un valor verifica si es menor que 0
        _IDPedidos = value;// cuando asignas un valor como DetallesDeLosPedidos.IDPedidos = 0, este no se asigna en IDPedidos sino que lo guarda en _IDPedidos
    }
}
*/