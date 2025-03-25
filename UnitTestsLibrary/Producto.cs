namespace UnitTestsLibrary
{
    /// <summary>
    /// A simple Producto class.
    /// </summary>
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto()
        {
            Id = 0;
            Nombre = string.Empty;
            Precio = 0.0m;
        }

        public decimal CalcularImporte(int cantidad) {
            return cantidad * Precio;
        }
    }
}