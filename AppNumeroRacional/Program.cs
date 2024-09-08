using System;
// EFRAIN VITORINO MARIN  COD: 160337

namespace AppNroRacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJANDO CON NUMEROS RACIONALES");

            // Crear la primera fracción y solicitar la entrada
            CNroRacional N1 = new CNroRacional();
            Console.WriteLine("Ingrese la primera fracción:");
            N1.ingresarFraccion();

            // Crear la segunda fracción y solicitar la entrada
            CNroRacional N2 = new CNroRacional();
            Console.WriteLine("Ingrese la segunda fracción:");
            N2.ingresarFraccion();

            // Mostrar las fracciones ingresadas
            Console.WriteLine("\nFracción N1:");
            N1.mostrarNroRacional();

            Console.WriteLine("Fracción N2:");
            N2.mostrarNroRacional();

            // Suma
            CNroRacional suma = N1.sumar(N2);
            Console.WriteLine("\nSuma de N1 y N2:");
            suma.mostrarNroRacional();

            // Resta
            CNroRacional resta = N1.restar(N2);
            Console.WriteLine("\nResta de N1 y N2:");
            resta.mostrarNroRacional();

            // Multiplicación
            CNroRacional multiplicacion = N1.multiplicar(N2);
            Console.WriteLine("\nMultiplicación de N1 y N2:");
            multiplicacion.mostrarNroRacional();

            // División
            CNroRacional division = N1.dividir(N2);
            Console.WriteLine("\nDivisión de N1 y N2:");
            division.mostrarNroRacional();

            Console.ReadKey();
        }
    }
}
