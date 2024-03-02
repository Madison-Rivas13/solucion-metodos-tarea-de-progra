using System;

public class Programa
{
    public static void Main(string[] args)
    {
        SumarDosValores();
    }

    public static void SumarDosValores()
    {
        try
        {
            Console.WriteLine("Ingrese el primer valor:");
            string input1 = Console.ReadLine();
            int valor1 = Convert.ToInt32(input1);

            Console.WriteLine("Ingrese el segundo valor:");
            string input2 = Console.ReadLine();
            int valor2 = Convert.ToInt32(input2);

            int suma = valor1 + valor2;
            Console.WriteLine($"La suma de {valor1} y {valor2} es: {suma}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Se esperaba un número entero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El número ingresado es muy grande o muy pequeño para ser representado como un entero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operación finalizada.");
        }
    }
}