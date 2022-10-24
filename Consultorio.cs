using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int MP, NC, PGC;

            Console.WriteLine("Actividad 3 Uso de variable if");
            Console.WriteLine("Programa para saber el numero de cita que se efectuara");
            //Entrada
            Console.WriteLine("Ingrese el numero de cita");
            NC = int.Parse(Console.ReadLine());
            //Proceso y salida
            PGC = 0;
            MP = 0;
            if (NC <= 0)
            {
                PGC = 0;
                MP = NC * 0;
                Console.WriteLine("Verifique el valor");
                Console.ReadKey();
            }
            else
            {
            if (NC >= 1 && NC <= 3)
            {
                PGC = 200;
                MP = NC * 200;
            }
            if (NC >= 4 && NC <= 5)
            {
                PGC = 150;
                MP = 3*200+(NC-3) * 150;
            }
            if (NC >= 6 && NC <= 8)
            {
                PGC = 100;
                MP = 3*200+2*150+(NC-5) * 100;
            }
            if (NC >= 9)
            {
                PGC = 50;
                MP = 3 * 200 + 2 * 150 + 3 * 100 + (NC - 8) * 50;
            }
            Console.WriteLine("El monto pagado es de:" + MP);
            Console.WriteLine("El valor del pago de la cita es de:"+ PGC);
            Console.ReadKey();
        }
    }
    }
}