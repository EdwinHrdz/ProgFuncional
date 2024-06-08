
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuPrin();
        }
    }
    public static void MenuPrin()
    {
        Console.Clear();
        Console.WriteLine("*************************************************************");
        Console.WriteLine("********************* - Menú Pricipal - *********************");
        Console.WriteLine("*************************************************************");
        Console.WriteLine(" ");
        Console.WriteLine("[1] - Función que valida si una persona es menor de edad o no");
        Console.WriteLine("[2] - Función que valida si un alumno aprobó o reprobó:");
        Console.WriteLine("[3] - Función que calcula el salario de una persona");
        Console.WriteLine("[4] - Función que valida si un número es primo");
        Console.WriteLine("[5] - Función tipo calculadora de la ley de Ohm");
        Console.WriteLine("[0] - Salir");
        Console.WriteLine(" ");
        Console.WriteLine(" Selecciona una Opcion con el numero: ");
        int resp = int.Parse(Console.ReadLine());

        switch (resp)
        {
            case 1:
                Console.Clear ();

                Console.WriteLine("[1] - Función que valida si una persona es menor de edad o no");
                Console.WriteLine("Ingrese edad:");

                int edad = Int32.Parse(Console.ReadLine());
                ValidarEdad(edad);
                break;
            case 2:
                Console.Clear();

                Console.WriteLine("[2] - Función que valida si un alumno aprobó o reprobó:");
                Console.WriteLine("Ingrese calificacion del alumno:");

                int calificacion = Int32.Parse(Console.ReadLine());
                ValidarCalificacion(calificacion);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("[3] - Función que calcula el salario de una persona");
                Console.WriteLine("Ingrese Salario Bruto Semanal");

                double salarioBruto = Convert.ToDouble(Console.ReadLine());
                CalcularSalario(salarioBruto);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("[4] - Función que valida si un número es primo");
                Console.WriteLine("Ingrese el numero a Evaluar:");
                
                int numero = Int32.Parse(Console.ReadLine());
                EsPrimo(numero);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("[5] - Función tipo calculadora de la ley de Ohm");
                double volt = 0;
                double rest = 0;
                double inte = 0;

                Console.WriteLine("Ingrese los valores solicitados, 0 si no sabe la respuesta");
                Console.WriteLine("Ingrese valor de Volaje");
                volt = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese Valor de Resistencia");
                rest = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese valor de Corriente");
                inte = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Convert.ToString(LeyDeOhm(volt, rest, inte)));
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opcion Incorrecta, Vuelve a intentarlo");
                Console.ReadLine();
                MenuPrin();
                break;
        }
    }
    public static void ValidarEdad(int edad)
    {
        if (edad < 18)
        {
            Console.WriteLine("Menor de Edad");
        }
        else
        {
            Console.WriteLine("Mayor de Edad");
        }
    }

    public static void ValidarCalificacion(int calificacion)
    {
        if (calificacion < 7)
        {
            Console.WriteLine("Reprobado");
        }
        else
        {
            Console.WriteLine("Aprobado");
        }
    }

    public static void CalcularSalario(double salarioBruto)
    {
        double isr = salarioBruto * 0.10;
        double ss = salarioBruto * 0.05;
        double salarioNeto = salarioBruto - isr - ss;

        Console.WriteLine($"Sueldo Bruto: {salarioBruto}");
        Console.WriteLine($"Sueldo Neto: {salarioNeto}");
    }

    public static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) ;
            {
                Console.WriteLine("El numero no primo");
                return false;
            }
            
        }
        Console.WriteLine("El numero es primo");
        return true;
    }

    public static double LeyDeOhm(double volt, double rest, double inte)
    {
        double resultado = 0;
        string tipo = null;

        if (volt == 0) tipo = tipo + "V";
        if (rest == 0) tipo = tipo + "R";
        if (inte == 0) tipo = tipo + "I";
        //Estoy haciendo que tipo sea diferente en los Case para que se maneje como error, 
        //si a los datos ingresados solo les falta u dato (0) entonces solo tendran una letra,
        //SI les falta mas de un dato, entonces sera de dos o mas letras y no entrara en el case.

        switch (tipo)
        {
            case "V":
                // V = I * R
                resultado = inte * rest;
                break;
            case "I":
                // I = V / R
                resultado = volt / rest;
                break;
            case "R":
                // R = V / I
                resultado = volt / inte;
                break;
            default:
                Console.WriteLine("Datos Invalidos, por favor revise los datos ingresados");
                break;
        }

        return resultado;
    }
}