using System;

public class Calculadora
{
    public int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Expresión invalida no es posible dividir por cero.");
            return 0;
        }
        return num1 / num2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculadora micalculadora = new Calculadora();

        // Solicitar los números al usuario
        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Realizar las operaciones
        int suma = micalculadora.Sumar(num1, num2);
        int resta = micalculadora.Restar(num1, num2);
        int multiplicacion = micalculadora.Multiplicar(num1, num2);
        int division = micalculadora.Dividir(num1, num2);

        // Mostrar los resultados
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División: {division}");
    }
}
