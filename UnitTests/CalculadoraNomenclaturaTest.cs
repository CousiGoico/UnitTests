namespace UnitTests
{
    using Xunit;
    using UnitTestsLibrary;

    /// <summary>
    /// Test class for the Calculadora class.
    /// </summary>
    public class CalculadoraNomenclaturaTest
    {
        private Calculadora? _calculadora;

        public CalculadoraNomenclaturaTest()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void Sumar_DosNumerosEnteros_OK()
        {
            int num1 = 2;
            int num2 = 3;
            int resultado = _calculadora!.Sumar(num1, num2);

            Assert.Equal(num1 + num2, resultado);
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
            int num1 = 999999999;
            int num2 = 999999999;
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
        public void Dividir_DosNumerosEnteros_KO()
        {
            int num1 = 6;
            int num2 = 0;
            double resultado = 0;
            try {
                resultado = _calculadora!.Dividir(num1, num2);
            }
            catch (DivideByZeroException ex) {
                Assert.Equal("No se puede dividir por cero", ex.Message);
            }
            finally {
                Assert.Equal(0, resultado);
            }
        }
    }
    
}

