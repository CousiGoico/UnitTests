using UnitTestsLibrary;

namespace UnitTestMSTest{

    [TestClass]
    public class UnitMSTest {

        [TestMethod]
        public void Sumar(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 + arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Sumar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void Restar(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 - arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Restar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void Multiplicar(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 * arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Multiplicar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void Dividir(){
            int arg1 = 6;
            int arg2 = 3;
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

    }
}