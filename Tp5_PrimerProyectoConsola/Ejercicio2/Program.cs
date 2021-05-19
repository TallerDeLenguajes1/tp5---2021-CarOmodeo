using System;


namespace Tp5Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            do
            {
                float num1, num2, resultado;
                int operacion;
                string tipoOperacion;

                do
                {
                    Console.WriteLine("Ingrese el codigo de la operacion que desea realizar (1.Suma, 2.Resta, 3.Multiplicacion, 4.Division):");
                    operacion = Convert.ToInt32(Console.ReadLine());
                } while (operacion != 1 && operacion != 2 && operacion != 3 && operacion != 4);

                Console.WriteLine("Ingrese un numero");
                num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese otro numero");
                num2 = float.Parse(Console.ReadLine());

                switch (operacion)
                {
                    case 1:
                        resultado = num1 + num2;
                        tipoOperacion = "Suma";
                        break;
                    case 2:
                        resultado = num1 - num2;
                        tipoOperacion = "Resta";
                        break;
                    case 3:
                        resultado = num1 * num2;
                        tipoOperacion = "Multiplicacion";
                        break;
                    default:
                        resultado = num1 / num2;
                        tipoOperacion = "Division";
                        break;

                }

                Console.WriteLine("La " + tipoOperacion + " es igual a " + Math.Round(resultado,2));


                Console.WriteLine("Desea realizar otra operacion? (Si/NO)");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta.Equals("si") || respuesta.Equals("s"));
        }
    }
}
