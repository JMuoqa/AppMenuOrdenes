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
        public string HoraIngresoPedido { get; set; }
        public string HoraEstimadaEntrega { get; set; }
    }
    public class DetallesDeLosPedidos
    {
        public int IDPedidos { get; set; }
        public int IDOrden { get; set; }
        public int IDMenu { get; set; }
        public string NombreMenu { get; set; }
        public int Cantidad { get; set; }
        public string Precio { get; set; }
    }
}
