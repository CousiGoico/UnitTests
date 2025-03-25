using NUnit.Framework;
using UnitTestsLibrary;

namespace UnitTestnUnit {

    [TestFixture]
    public class nUnitEtiequetas {

        [SetUp]
        public void Setup(){
            // Inicialización de variables o recursos comunes para los tests
        }

        [TearDown]
        public void TearDown(){
            // Inicialización de variables o recursos comunes para los tests
        }

        [OneTimeSetUp]
        public void OneTimeSetUp(){
            // Inicialización de variables o recursos comunes para los tests
        }

        [OneTimeTearDown]
        public void OneTimeTearDown(){
            // Inicialización de variables o recursos comunes para los tests
        }

        [Test]
        [Author("Javier Cousiño")]
        [Description("Sumar dos números enteros y el resultado es OK")]
        [Category("OperacionMatematica")]
        [Property("Prioridad", "Alta")]
        public void Sumar_DosNumerosEnteros_ResultadoOK(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 + arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Sumar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [Test]
        [Author("Javier Cousiño")]
        [Description("Restar dos números enteros y el resultado es OK")]
        [Category("OperacionMatematica")]
        [Property("Prioridad", "Media")]
        public void Restar_DosNumerosEnteros_ResultadoOK(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 - arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Restar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [Test]
        [Author("Javier Cousiño")]
        [Description("Multiplicar dos números enteros y el resultado es OK")]
        [Category("OperacionMatematica")]
        [Property("Prioridad", "Baja")]
        public void Multiplicar_DosNumerosEnteros_OK(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 * arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Multiplicar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [Test]
        [Author("Javier Cousiño")]
        [Description("Dividir dos números enteros y el resultado es OK")]
        [Category("OperacionMatematica")]
        [Property("Prioridad", "Alta")]
        public void Dividir_DosNumerosEnteros_ResultadoOK(){
            int arg1 = 6;
            int arg2 = 3;
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

         [Test]
        [Author("Javier Cousiño")]
        [Description("Dividir dos números enteros y el resultado es OK")]
        [Category("OperacionMatematica")]
        [Property("Prioridad", "Alta")]
        [Ignore("División por cero no es válida")]
        public void Dividir2_DosNumerosEnterosA_ResultadoOKA(){
            int arg1 = 9;
            int arg2 = 3;
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

                 [Test]
        [Author("Javier Cousiño")]
        [Description("Dividir dos números enteros y el resultado es OK")]
        [Category("OperacionMatematica")]
        [Property("Prioridad", "Alta")]
        [Timeout(1000)]
        public void Dividir3_DosNumerosEnterosB_ResultadoOKB(){
            int arg1 = 16;
            int arg2 = 8;
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

         private static Random random = new Random();

        // [Test]
        // [Author("Javier Cousiño")]
        // [Description("Dividir dos números enteros y el resultado es OK")]
        // [Category("OperacionMatematica")]
        // [Property("Prioridad", "Alta")]
        // [Retry(3)] // Si el test falla, se reintentará hasta 3 veces antes de fallar definitivamente
        // public void Prueba_Con_Retry()
        // {
        //     int numero = random.Next(1, 5); // Genera un número entre 1 y 4
        //     Console.WriteLine($"Número generado: {numero}");
        //     Assert.AreEqual(3, numero);
        // }

    }
}