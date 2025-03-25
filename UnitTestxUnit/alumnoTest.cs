using System.ComponentModel;
using Moq;
using UnitTestsLibrary;
using UnitTestxUnit;

namespace UnitTestxUnit {

    public class AlumnoTest {

        [Fact]
        [Trait("Prioridad", "Alta")]
        [Trait("Autor", "Javier Cousiño")]
        [Description("Suma de dos números")]
        [Category("OperacionCalculadora")]

        public void AlumnoObtenerNotas_Id1_ResultadoOk()
        {
            // Arrange
            var servicio = new NotasService();
            var alumno = new Alumno(servicio) { Id = 1, Nombre="Juan", Apellido="Pérez" };
            var resultadoEsperado = servicio.ObtenerNotas(alumno.Id).Sum() / servicio.ObtenerNotas(alumno.Id).Count();

            // Act
            var resultado = alumno.ObtenerMediaNotas();

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        [Trait("Prioridad", "Alta")]
        [Trait("Autor", "Javier Cousiño")]
        [Description("Suma de dos números")]
        [Category("OperacionCalculadora")]
        public void AlumnoObtenerNotas_Id1ConMock_ResultadoOk()
        {
            // Arrange
            var mockNotasService = new Mock<INotasService>();
            mockNotasService.Setup(ns => ns.ObtenerNotas(1)).Returns(new List<int> { 2, 2, 2, 2 });
            mockNotasService.Setup(ns => ns.ObtenerNotas(2)).Returns(new List<int> { 4, 4, 4, 4 });
            mockNotasService.Setup(ns => ns.ObtenerNotas(3)).Returns(new List<int> { 6, 6, 6, 6 });

            var alumno = new Alumno(mockNotasService.Object) { Id = 3, Nombre="Juan", Apellido="Pérez" };

            // Act
            var resultado = alumno.ObtenerMediaNotas();

            // Assert
            Assert.Equal(6, resultado);
            mockNotasService.Verify(ns => ns.ObtenerNotas(It.IsAny<int>()), Times.Once());
        }
    }
}