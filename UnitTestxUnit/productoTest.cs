using System.ComponentModel;
using UnitTestsLibrary;
using UnitTestxUnit;

namespace UnitTestxUnit;

public class ProductoTest{

    [Fact]
    [Trait("Prioridad", "Alta")]
    [Trait("Autor", "Javier Cousiño")]
    [Description("Calculo del importe de un producto")]
    [Category("Products")]

    public void CalculoImporte_Producto_ResultadoOk()
    {
        // Arrange
        int cantidad = 3;
        decimal precio = 12.5m;
        Producto producto = new Producto() { Id = 1, Nombre ="Palomitas", Precio = 12.5m};

        // Act
        var importe = producto.CalcularImporte(cantidad);

        // Assert
        Assert.Equal(cantidad * precio, importe);
        Assert.IsType<decimal>(importe);
        Assert.True(importe > 0, "El importe debe ser mayor que cero.");
        Assert.False(importe == 0, "El importe no debe ser 0, ya que sería gratis.");
        Assert.False(importe < 0, "El importe no debe ser negativo, ya que el vendedor debe pagar.");
        Assert.InRange(importe, 1, 1000);
    }
}