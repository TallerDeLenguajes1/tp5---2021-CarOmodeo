using System;

namespace Tp5Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0;
            Console.WriteLine("Ingrese un numero entero: ");
            a = Convert.ToInt32(Console.ReadLine());

            if(a > 0)
            {
                while(a > 0)
                {
                    b = b * 10 + (a % 10);
                    a /= 10;
                }
                Console.WriteLine("El num invertido es " + b);
            }
            else
            {
                Console.WriteLine("No se puede realizar la invercion del numero");
            }
        }
    }
}
