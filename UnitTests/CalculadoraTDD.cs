namespace UnitTests
{
    using Xunit;
    using UnitTestsLibrary;

    /// <summary>
    /// Test class for the Calculadora class.
    /// </summary>
    public class CalculadoraTDDTest
    {
        private Calculadora? _calculadora;

        public CalculadoraTDDTest()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void Sumar_DosNumerosEnteros_OK() {
            // Arrange
            int num1 = 999999999;
            int num2 = 999999998;
            int resultado = 0;

            // Act
            resultado = _calculadora!.Sumar(num1, num2);

            // Assert
            Assert.NotEqual(0, num1);
            Assert.NotEqual(0, num2);
            Assert.Equal(num1 + num2, resultado);
            Assert.NotEqual(num1, resultado);
            Assert.NotEqual(num2, resultado);
            Assert.IsType<int>(resultado);

        }

    }
    
}

