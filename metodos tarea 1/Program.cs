using System;

public class Program
{
    public static void Main(string[] args)
    {
        PedirIngresosYMostrarMensajes();
    }

    public static void PedirIngresosYMostrarMensajes()
    {
        Console.WriteLine("Ingrese su nombre:");
        string nombreUsuario = Console.ReadLine();

        Console.WriteLine("Introduce tus ingresos del primer Mes:");
        double ingresosMes1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce tus ingresos del segundo Mes:");
        double ingresosMes2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce tus ingresos del tercer Mes:");
        double ingresosMes3 = Convert.ToDouble(Console.ReadLine());

        double sumaIngresos = ingresosMes1 + ingresosMes2 + ingresosMes3;
        double promedioIngresos = sumaIngresos / 3;

        Console.WriteLine($"Hola {nombreUsuario}, en total ganaste {sumaIngresos} y promediaste {promedioIngresos}");
    }
}
