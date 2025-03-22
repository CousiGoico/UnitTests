namespace UnitTests
{
    using Xunit;
    using UnitTestsLibrary;

    /// <summary>
    /// Test class for the Calculadora class.
    /// </summary>
    public class CalculadoraAAATest
    {
        private Calculadora? _calculadora;

        public CalculadoraAAATest()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void Sumar_DosNumerosEnteros_OK()
        {
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

        [Fact]
        public void Restar_DosNumerosEnteros_OK()
        {
            int num1 = 2;
            int num2 = 3;
            int resultado = _calculadora!.Restar(num1, num2);

            Assert.Equal(num1 - num2, resultado);
        }

        [Fact]
        public void Multiplicar_DosNumerosEnteros_OK()
        {
            int num1 = 2;
            int num2 = 3;
            int resultado = _calculadora!.Multiplicar(num1, num2);

            Assert.Equal(num1 * num2, resultado);
        }

        [Fact]
        public void Dividir_DosNumerosEnteros_OK()
        {
            int num1 = 6;
            int num2 = -1;
            double resultado = _calculadora!.Dividir(num1, num2);

            Assert.Equal(num1 / num2, resultado);
        }

        [Fact]
        public void Dividir_DosNumerosEnteros_ThrowException()
        {
            int num1 = 6;
            int num2 = 0;
            double resultado = 0;
            string message = "No se puede dividir por cero";
            try {
                resultado = _calculadora!.Dividir(num1, num2);
            }
            catch (DivideByZeroException ex) {
                Assert.Equal(message, ex.Message, true, false, true, false);
            }
            finally {
                Assert.Equal(0, resultado);
            }
        }

                [Fact]
        public void Dividir_DosNumerosEnteros_AssertThrowException()
        {
            int num1 = 6;
            int num2 = 0;

            Assert.Throws<DivideByZeroException>(() => _calculadora!.Dividir(num1, num2));
            
        }
    }
    
}

