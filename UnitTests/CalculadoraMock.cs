namespace UnitTests
{
    using Xunit;
    using UnitTestsLibrary;
    using Moq;

    /// <summary>
    /// Test class for the Calculadora class.
    /// </summary>
    public class CalculadoraMoqTest
    {
        [Fact]  
        public void Sumar_DosNumerosEnteros_OK()
        {
            // Arrange
            var mockService = new Mock<ICalculadora>();
            mockService.Setup(s => s.ObtenerMultiplicador(1)).Returns(3);

            var calculadoraAvanzada = new CalculadoraAvanzada(mockService.Object);

            // Act
            var resultado = calculadoraAvanzada.MultiplicarPorValor(5);

            // Assert
            Assert.Equal(15, resultado);
            mockService.Verify(s => s.ObtenerMultiplicador(It.IsAny<int>()), Times.Once);

        }

    }
    
}


