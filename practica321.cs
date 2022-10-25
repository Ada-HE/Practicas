using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double SALDOA, MCR, PGD, SALDOAN, INTERESES, MULT, PAGM, PAGNI;

            Console.WriteLine("Actividad 3.21 Uso de variable if");
            Console.WriteLine("Programa para calcular el pago minimo, saldo actual y no generar intereses");
            //Entrada
            Console.WriteLine("Ingrese el saldo anterior");
            SALDOAN = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto de compras que realizo");
            MCR = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el pago que deposito en el corte anterior");
            PGD= double.Parse(Console.ReadLine());
            //Proceso y salida
            if (SALDOAN*.015 >PGD)
            {
                INTERESES = SALDOAN * 0.12;
                MULT = 200;
            }
            else
            {
                INTERESES = 0;
                MULT = 0;   
            }
            SALDOA= SALDOAN+MCR-PGD+INTERESES+MULT;
            PAGM = SALDOA * 0.15;
            PAGNI = SALDOA * 0.85;
            Console.WriteLine("El valor del saldo actual es:" + SALDOA);
            Console.WriteLine("El valor del pago minimo es de:" + PAGM);
            Console.WriteLine("El valor del pago para no generar intereses es de:" + PAGNI);
            Console.WriteLine("El valor de los intereses son de:" + INTERESES);
            Console.WriteLine("El valor de la multa es:" + MULT);
            Console.ReadKey();
        }
    }
}
