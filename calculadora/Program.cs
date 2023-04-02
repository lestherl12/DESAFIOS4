using System;

public class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: no se puede dividir entre cero.");
            return 0;
        }
        else
        {
            return a / b;
        }
    }
}

public class CalculadoraCientifica : Calculadora
{
    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Raiz(double a)
    {
        return Math.Sqrt(a);
    }

    public double Modulo(double a, double b)
    {
        return a % b;
    }

    public double Logaritmo(double a, double b)
    {
        return Math.Log(a, b);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // instancia de la clase Calculadora
        Calculadora calc = new Calculadora();
        Console.WriteLine("Calculadora básica:");
        Console.WriteLine("10 + 5 = {0}", calc.Sumar(10, 5));
        Console.WriteLine("10 - 5 = {0}", calc.Restar(10, 5));
        Console.WriteLine("10 * 5 = {0}", calc.Multiplicar(10, 5));
        Console.WriteLine("10 / 5 = {0}", calc.Dividir(10, 5));

        //  instancia de la clase CalculadoraCientifica
        CalculadoraCientifica calcCientifica = new CalculadoraCientifica();
        Console.WriteLine("\nCalculadora científica:");
        Console.WriteLine("2^3 = {0}", calcCientifica.Potencia(2, 3));
        Console.WriteLine("Raíz cuadrada de 16 = {0}", calcCientifica.Raiz(16));
        Console.WriteLine("15 % 4 = {0}", calcCientifica.Modulo(15, 4));
        Console.WriteLine("Logaritmo base 10 de 1000 = {0}", calcCientifica.Logaritmo(1000, 10));

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}