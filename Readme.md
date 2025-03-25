# Instrucciones


## Nueva solución 

        dotnet new sln --name {name}

## Nuevo proyecto de tipo libreria de clases

        dotnet new classlib --name {nameProjectLibrary}

        dotnet sln add {nameProjectLibrary}

## Nuevo proyecto de tipo pruebas unitarios con MSTest (UnitTestMSTest)

        dotnet new mstest --name {UnitTestMSTest}

        dotnet sln add {UnitTestMSTest}

## Añado referencia de calculadora en proyecto de pruebas

        cd {nameProjectLibrary}

        dotnet add reference ..\{nameProjectLibrary}

## Añado la clase calculadora a la libreria de clases

En el dividir establecer una verificación de división por 0.

        if (b == 0)
            throw new DivideByZeroException("No se puede dividir por cero");

## MSTest

### Creo una clase en el proyecto de tests unitarios llamada CalculadoraMSTest

Realizo los tests básicos de la calculadora.

### Creo una clase terminada MSTTestNormativa

Realizo los mismos tests pero esta vez hablando de la normativa de nombres.

    - Método_Escenario_ResultadoEsperado: Add_TwoPositiveNumbers_ReturnsCorrectSum

    - Cuando_Escenario_Entonces_ResultadoEsperado: Cuando_SumaDosNumerosPositivos_Entonces_RetornaLaSumaCorrecta

    - Given_When_Then: GivenTwoPositiveNumbers_WhenAdded_ThenReturnsCorrectSum

    - Escenario_ResultadoEsperado:SumOfTwoPositiveNumbers_ShouldReturnCorrectSum

### Creo una clases terminada en MSTTestAssert

Realizo los mismos tests pero esta vez añadiendo más asserts.

### Creo una clase terminada en MSTestEtiquetas

[TestClass]
[TestMethod]
[TestInitialize] - Inicio
[TestCleanup] - Fin
[Owner]
[Description]
[Priority] -> (1 alto, 2 medio, 3 bajo)
[TestCategory]
[Ignore]
[Timeout]

## nUnit

### Creo un proyecto nuevo con el framework de nUnit

dotnet new nunit --name {UnitTestnUnit}

dotnet add package nUnit3TestAdapter

dotnet sln add {UnitTestnUnit}

cd {UnitTestnUnit}

dotnet add reference ..\{nameProjectLibrary}

***** Cambiar la versión del paquete "NUnit" a 3.14.0

### Creo una clase terminada en nUnitEtiquetas

[TestFixture]
[Test]
[Setup] - Inicio
[TearDown] - Fin
[OneTimeSetUp] - Inicio
[OneTimeTearDown] - Fin
[Author]
[Description]
[Propertty] -> (1 alto, 2 medio, 3 bajo)
[Category]
[Timeout] -> Obsolete
[Ignore]

### Creo un proyecto nuevo con el framework de xUnit

dotnet new xunit --name {UnitTestxUnit}

dotnet sln add {UnitTestxUnit}

cd {UnitTestxUnit}

dotnet add reference ..\{UnitTestxUnit}

### Creo una clase terminada en xUnitEtiquetas

[Fact]
[Description]
[Category]
[Trait("Author", "Javier Cousiño")]
[Trait("Priority", "Alta")]
[Fact(Skip="No se ejecuta")]
[Fact(Timeout="No se ejecuta")]

## Mock

Installar Moq

dotnet add package moq

### Creacion de la entidad Alumno

                namespace UnitTestsLibrary{
                        public class Alumno
                        {
                                private readonly INotaService _notaService;

                                public int Id { get; set; }
                                public string Nombre { get; set; }

                                public Alumno(int id, string nombre, INotaService notaService)
                                {
                                        Id = id;
                                        Nombre = nombre;
                                        _notaService = notaService;
                                }

                                // Método para calcular la media de las notas
                                public double CalcularMedia()
                                {
                                        var notas = _notaService.ObtenerNotas(Id);
                                        if (notas == null || notas.Count == 0) return 0;

                                        return notas.Average();
                                }
                        }
                }

### Creación de la interfaz
                namespace UnitTestsLibrary{ 
                        public interface INotasService {
                                List<int> ObtenerNotas(int idAlumno);
                        }
                }

### Creamos el servicio que implementa la interfaz

                namespace UnitTestsLibrary {
                        public class NotasService : INotasService {
                                public List<int> ObtenerNotas(int idAlumno) {
                                return new List<int>(){ 5, 7, 6, 8 };
                                }
                        }
                }

### Creo clase en el proyecto de test unitarios de xUnit

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

### Explicación de la inyección de dependencias

Técnica de programación que permite que un objeto o función reciba sus dependencias de una fuente externa

## Ejemplo de TDD

### Creación del test ProductoTest.cs (RED)

### Creación de la clase Producto.cs (GREEN)

### Explicación Refactorizar

## Ejecución de test mediante linea de comandos

### Todos

                dotnet test

### Por proyecto

                dotnet test {project}

### Listar los tests

                dotnet test -t

### Ejecución de tests filtrandolos por línea de comandos

                dotnet test --filter "Owner=Javier Cousiño"

### Ejecución de tests sin compilar

                dotnet test --no-build

### Ejecución de tests sin restaurar

                dotnet test --no-restore

### Ejecución de tests verbosity

                dotnet test --verbosity detailed

### Ejecución de tests con diferente framework

                dotnet test --framework net9.0

## Ejemplo obtener cobertura desde línea de comandos

### Demostración de la cobertura en VS Code

### Instalar paquete nuget Coverlet

                dotnet add package coverlet.console

#### Ejecución de tests con cobertura

                dotnet test --collect:"XPlat Code Coverage"

#### Instalación herramienta ReportGenerator

                dotnet tool install --global dotnet-reportgenerator-globaltool

#### Ejecución de la herramienta ReportGenerator

                reportgenerator -reports:TestResults\3d79106b-b232-41bf-9f2e-c4c5903f01cb\coverage.cobertura.xml -targetdir:coverage-report

## GitHub Copilot testing prompts

### Definición y registro de cuenta en GitHub

### Definición de control de versiones GIT, comparación entre GitHub y Azure DevOps

