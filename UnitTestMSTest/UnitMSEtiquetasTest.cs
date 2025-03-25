using System.Runtime.InteropServices;
using UnitTestsLibrary;

namespace UnitTestMSTest{

    [TestClass]
    public class UnitMSEtiquetasTest {

        // Atributos
        private int arg1;
        private int arg2;

        [TestInitialize]
        public void Initialize(){
            arg1 = 46;
            arg2 = 23;
        }

        [TestCategory("OperacionCalculadora")]
        [Priority(1)]
        [Description("Suma de dos números")]
        [Owner("Javier Cousiño")]
        [TestMethod]
        public void SumarA(){
            int resultadoEsperado = arg1 + arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Sumar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestCategory("OperacionCalculadora")]
        [Priority(1)]
        [Description("Resta de dos números")]
        [Owner("Javier Cousiño")]
        [TestMethod]
        public void RestarA(){
            int resultadoEsperado = arg1 - arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Restar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestCategory("OperacionCalculadora")]
        [Priority(2)]
        [Description("Multiplicación de dos números")]
        [Owner("Javier Cousiño")]
        [TestMethod]
        public void MultiplicarA(){
            int resultadoEsperado = arg1 * arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Multiplicar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestCategory("OperacionCalculadora")]
        [Priority(3)]
        [Description("División de dos números")]
        [Owner("Javier Cousiño")]
        [TestMethod]
        public void DividirA(){
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

    }
}