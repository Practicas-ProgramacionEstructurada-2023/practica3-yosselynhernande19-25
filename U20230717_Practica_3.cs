using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //Declaracion de variables
            string? Marca_Zapato;
            string? Color_Zapato;
            int Cantidad;
            double Precio_Zapato;

            //Capturando datos
            Console.WriteLine("\n-------Capturando Variables--------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese la marca de zapatos a comprar:");
            Marca_Zapato = Convert.ToString(Console.ReadLine());

            
            Console.WriteLine("\nIngrese el color del par de zapatos:");
            Color_Zapato = Convert.ToString(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nIngrese la cantidad de pares de zapato a comprar:");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese el precio del par de zapatos a comprar:");
            Precio_Zapato = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("-----Fin de Capturacion de variables--------\n");

            //Capturando el total a pagar
            double Total = Cantidad * Precio_Zapato;

            //Impresion resultando
            Console.WriteLine("\n------------Imprimiendo resultados-----------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("La marca de zapatos a comprar es: " + Marca_Zapato);
            Console.WriteLine("\nColor de zapatos a comprar es:" + Color_Zapato);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLa cantidad de pares de zapato a compara es:" + Cantidad);
            Console.WriteLine("\nEl precio por par de zapatos a comprar es:" +Precio_Zapato );
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTotal a pagar es:" + Total);
            Console.ResetColor();
            Console.WriteLine("------------Fin de imprimir resultados-----------\n");
            






    


        }
    }
}