using System;

namespace Tp5_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num, num2;
            Console.WriteLine("Ingrese un numero real (decimales usar ,): ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("El valor absoluto de " + num + " es: " + Math.Abs(num));
            Console.WriteLine("El cuadrado de " + num + " es: " + (float)(Math.Round(Math.Pow(num,2),2)));
           
            if(num < 0)
            {
                Console.WriteLine("La raiz cuadrada de " + num + " es: " + (float)(Math.Round(Math.Sqrt(Math.Abs(num)), 2)) + "i");
            }
            else
            {
                Console.WriteLine("La raiz cuadrada de " + num + " es: " + (float)(Math.Round(Math.Sqrt(num), 2)));
            }

            Console.WriteLine("El Seno de " + num + " es: " + Math.Round(Math.Sin(num), 2));
            Console.WriteLine("El Coseno de " + num + " es: " + Math.Round(Math.Cos(num), 2));
            Console.WriteLine("La parte entera de " + num + " es: " + Math.Round(Math.Truncate(num), 2));

            Console.WriteLine("Ingrese un numeros: ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numeros: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("El maximo es: " + Math.Round(Math.Max(num, num2),2));
            Console.WriteLine("El minimo es: " + Math.Round(Math.Min(num, num2), 2));

        }
    }
}
