namespace UnitTests
{
    using Xunit;
    using UnitTestsLibrary;

    /// <summary>
    /// Test class for the Calculadora class.
    /// </summary>
    public class CalculadoraTest
    {
        private Calculadora? _calculadora;

        public CalculadoraTest()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void TestSumar()
        {
            int num1 = 2;
            int num2 = 3;
            int resultado = _calculadora!.Sumar(num1, num2);

            Assert.Equal(num1 + num2, resultado);
        }

                [Fact]
        public void TestRestar()
        {
            int num1 = 2;
            int num2 = 3;
            int resultado = _calculadora!.Restar(num1, num2);

            Assert.Equal(num1 - num2, resultado);
        }

        [Fact]
        public void TestMultiplicar()
        {
            int num1 = 2;
            int num2 = 3;
            int resultado = _calculadora!.Multiplicar(num1, num2);

            Assert.Equal(num1 * num2, resultado);
        }

                        [Fact]
        public void TestDividir()
        {
            int num1 = 6;
            int num2 = 3;
            double resultado = _calculadora!.Dividir(num1, num2);

            Assert.Equal(num1 / num2, resultado);
        }
    }
    
}

