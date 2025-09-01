namespace ClasesG
{
    public class Menus
    {
        public int IDMenu { get; set; }
        public string NombreMenu { get; set; }
        public string IngredientesMenu { get; set; }
        public int TipoMenu { get; set; }
        public string PrecioMenu { get; set; }
    }
    public class Orden
    {
        public int IDOrden { get; set; }
        public string NombreCliente { get; set; }
        public string NumeroCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string PrecioTotal {  get; set; }
        public string Comentarios { get; set; }
        public int ProductosSeleccionados { get; set; }
        public DateTime HoraIngresoPedido { get; set; }
        public DateTime HoraEstimadaEntrega { get; set; }
        public string Estado { get; set; }
    }
    public class DetallesDeLosPedidos
    {
        /*
            Si no tuvieras el campo privado (_precio) y pusieras Precio = value;, 
            entrarías en un bucle infinito porque el set estaría llamando al mismo set otra vez.get
            Esto esta MAL:
            public int IDPedidos { 
                get
                {
                    return IDPedidos; // o return value MAL
                }
                set 
                { 
                    if(value < 0) throw new Exception("El precio no puede ser negativo");
                    IDPedidos = value; // MAL SE CREA UN CICLO INFINITO
                }
            }
        */
        private int _IDPedidos;
        public int IDPedidos //IDPedidos no es una variable independiente, es una propiedad que actúa como una "capa de acceso" a la variable privada _IDPedidos.
        { 

            get => _IDPedidos; // cuando lees DetallesDeLosPedidos.IDPedidos devuelve _IDPedidos
            set 
            { if(value < 0) throw new Exception("El precio no puede ser negativo");// Antes de asignas un valor verifica si es menor que 0
                _IDPedidos = value;// cuando asignas un valor como DetallesDeLosPedidos.IDPedidos = 0, este no se asigna en IDPedidos sino que lo guarda en _IDPedidos
            }
        }
        public int IDOrden { get; set; }
        public int IDMenu { get; set; }
        public string NombreMenu { get; set; }
        public int Cantidad { get; set; }
        public string Precio { get; set; }
        public string Activo { get; set; }
    }
}
