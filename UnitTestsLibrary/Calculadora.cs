
namespace UnitTestsLibrary;

/// <summary>
/// A simple Calculadora class.
/// </summary>
public class Calculadora: ICalculadora {

    public Calculadora() { }
    public int ObtenerMultiplicador(int num)
    {
        return num * 2;
    }
    public int Sumar(int a, int b) => a + b;
    public int Restar(int a, int b) => a - b;
    public int Multiplicar(int a, int b) => a * b;

    public double Dividir(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("No se puede dividir por cero");
        return (double)a / b;
    }
}

public class CalculadoraAvanzada
{
    private readonly ICalculadora _calculadoraService;

    public CalculadoraAvanzada(ICalculadora calculadoraService)
    {
        _calculadoraService = calculadoraService;
    }

    public int MultiplicarPorValor(int numero)
    {
        return numero * _calculadoraService.ObtenerMultiplicador(1);
    }
}

