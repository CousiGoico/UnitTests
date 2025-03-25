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

dotnet sln add {UnitTestnUnit}

cd {UnitTestnUnit}

dotnet add reference ..\{nameProjectLibrary}

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
[Retry]

### Creo un proyecto nuevo con el framework de xUnit

dotnet new xUnit --name {UnitTestxUnit}

dotnet sln add {UnitTestxUnit}

cd {UnitTestxUnit}

dotnet add reference ..\{UnitTestxUnit}

## Ejecución de test mediante linea de comandos

### Ejecución de tests filtrandolos por línea de comandos

## Ejemplo obtener cobertura desde línea de comandos

## Interfaz VS Code -> cobertura
