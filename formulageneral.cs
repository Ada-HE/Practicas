using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0, x2 = 0, a = 0, c = 0, b = 0, sqrt = 0;
            Console.WriteLine("Calculadora cuadrática");
            Console.WriteLine("Ingrese el valor de a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de c");
            c = double.Parse(Console.ReadLine());

            sqrt = Math.Sqrt(Math.Pow(b,2) - 4 *(a)*(c));
            if (sqrt > 1)
            {
                x1 = (-b + sqrt) / 2 * a;
                x2 = (-b - sqrt) / 2 * a;
                Console.WriteLine("El valor de x1 es de: " + x1);
                Console.WriteLine("El valor de x2 es de: " + x2);
            }
            else
            {
                Console.WriteLine("Verificar los datos");
            }
            Console.ReadKey();
        }
    }
}
