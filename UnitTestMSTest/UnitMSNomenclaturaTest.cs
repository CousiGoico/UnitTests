using UnitTestsLibrary;

namespace UnitTestMSTest{

    [TestClass]
    public class UnitMSNomenclaturaTest {

        [Description("Método_Escenario_ResultadoEsperado")]
        [TestMethod]
        public void Sumar_DosNumerosEnteros_NumerosSumadosOK(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 + arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Sumar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [Description("Cuando_Escenario_Entonces_ResultadoEsperado")]
        [TestMethod]
        public void Cuando_SumaDosNumerosEnteros_Entonces_NumerosSumadosOK(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 - arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Restar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [Description("Given_When_Then")]
        [TestMethod]
        public void GivenDosNumerosEnteros_WhenMultiplicar_ThenNumerosEnterosMultiplicadosOK(){
            int arg1 = 2;
            int arg2 = 3;
            int resultadoEsperado = arg1 * arg2;
            Calculadora calculadora = new Calculadora();

            int resultadoObtenido = calculadora.Multiplicar(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [Description("Escenario_ResultadoEsperado")]
        [TestMethod]
        public void DividirDosNumerosEnteros_DebeDividirDosNumerosOK(){
            int arg1 = 6;
            int arg2 = 3;
            double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            double resultadoObtenido = calculadora.Dividir(arg1, arg2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

                [Description("Escenario_ResultadoEsperado")]
        [TestMethod]
        public void DividirDosNumerosEnteros_DebeDividirDosNumerosKO(){
            int arg1 = 6;
            int arg2 = 0;
            //double resultadoEsperado = arg1 / arg2;
            Calculadora calculadora = new Calculadora();

            //Assert.ThrowsException<DivideByZeroException>(() => calculadora.Dividir(arg1, arg2));

            try {
                calculadora.Dividir(arg1, arg2);
            }
            catch (DivideByZeroException ex) {
                Assert.AreEqual("No se puede dividir por cero", ex.Message);
            }
            catch (Exception ex) {
                Assert.Fail("Se esperaba una excepción DivideByZeroException, pero se lanzó una excepción diferente: " + ex.Message);
            }
            
        }

    }
}