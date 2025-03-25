using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks;
using UnitTestsLibrary;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace UnitTestxUnit{

    public class BeforeAfterTest : BeforeAfterTestAttribute {
        public override void Before(MethodInfo methodUnderTest) {
            // Código a ejecutar antes de cada test
            Console.WriteLine($"Iniciando test: {methodUnderTest.Name}");
        }
        public override void After(MethodInfo methodUnderTest) {
            // Código a ejecutar después de cada test
            Console.WriteLine($"Finalizando test: {methodUnderTest.Name}");
        }

    }

    public class xUnitEtiquetas {

        [Fact]
        [Trait("Prioridad", "Alta")]
        [Trait("Autor", "Javier Cousiño")]
        [Description("Suma de dos números")]
        [Category("OperacionCalculadora")]
        [BeforeAfterTest]
        public void Sumar(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 + arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Sumar(arg1, arg2);

            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact]
        [Trait("Prioridad", "Alta")]
        [Trait("Autor", "Javier Cousiño")]
        [Description("Suma de dos números")]
        [Category("OperacionCalculadora")]
        public void Restar(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 - arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Restar(arg1, arg2);

            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact]
        [Trait("Prioridad", "Alta")]
        [Trait("Autor", "Javier Cousiño")]
        [Description("Suma de dos números")]
        [Category("OperacionCalculadora")]
        public void Multiplicar(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 * arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Multiplicar(arg1, arg2);

            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact]
        [Trait("Prioridad", "Alta")]
        [Trait("Autor", "Javier Cousiño")]
        [Description("Suma de dos números")]
        [Category("OperacionCalculadora")]
        public void Dividir(){
            int arg1 = 6;
            int arg2 = 3;
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact(Skip = "No se ejecuta")]
        [Trait("Prioridad", "Alta")]
        [Trait("Autor", "Javier Cousiño")]
        [Description("Suma de dos números")]
        [Category("OperacionCalculadora")]
        public void Dividir2(){
            int arg1 = 6;
            int arg2 = 3;
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact(Timeout = 1000)]
        [Trait("Prioridad", "Alta")]
        [Trait("Autor", "Javier Cousiño")]
        [Description("Suma de dos números")]
        [Category("OperacionCalculadora")]
        public async Task Dividir3(){
            int arg1 = 6;
            int arg2 = 3;
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();
            await Task.Delay(500);
            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }
    }
}