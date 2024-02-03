using System;

class ejercicio4
{
    static void Main()
    {
        Console.Write("Introduce la base del cuadrado: ");
        double baseCuadrado = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la altura del cuadrado: ");
        double alturaCuadrado = Convert.ToDouble(Console.ReadLine());

        double areaCuadrado = baseCuadrado * alturaCuadrado;

        Console.WriteLine("El área del cuadrado es: " + areaCuadrado);
    }
}