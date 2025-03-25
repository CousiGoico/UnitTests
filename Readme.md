# Instrucciones


## Nueva solución 

        dotnet new sln --name {name}

## Nuevo proyecto de tipo libreria de clases

        dotnet new classlib --name {nameProjectLibrary}

        dotnet sln add {nameProjectLibrary}

## Nuevo proyecto de tipo pruebas unitarios con MSTest (UnitTestMSTest)

        dotnet new mstest --name {nameUnitTestMSTestProject}

        dotnet sln add {nameUnitTestMSTestProject}

## Añado referencia de calculadora en proyecto de pruebas

        cd {nameProjectLibrary}

        dotnet add reference ..\{nameProjectLibrary}

## Añado la clase calculadora a la libreria de clases

En el dividir establecer una verificación de división por 0.

        if (b == 0)
            throw new DivideByZeroException("No se puede dividir por cero");

### Creo una clase en el proyecto de tests unitarios llamada CalculadoraMSTest

Realizo los tests básicos de la calculadora.

### Creo una clase terminada Normativa

Realizo los mismos tests pero esta vez hablando de la normativa de nombres.

    - Método_Escenario_ResultadoEsperado: Add_TwoPositiveNumbers_ReturnsCorrectSum

    - Cuando_Escenario_Entonces_ResultadoEsperado: Cuando_SumaDosNumerosPositivos_Entonces_RetornaLaSumaCorrecta

    - Given_When_Then: GivenTwoPositiveNumbers_WhenAdded_ThenReturnsCorrectSum

    - Escenario_ResultadoEsperado:SumOfTwoPositiveNumbers_ShouldReturnCorrectSum

### Creo una clase terminada en Etiquetas

[TestClass]
[TestMethod]
[TestInitialize]
[Owner]
[Description]
[Priority] -> (1 alto, 2 medio, 3 bajo)
[TestCategory]

### Creo una clases terminada en Assert

Realizo los mismos tests pero esta vez añadiendo más asserts.