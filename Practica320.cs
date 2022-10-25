using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int MODEL, TALLA;
            double NUMP, CARGOT, CT, GA, GAX, MO, MTT,MTST, PF;

            Console.WriteLine("Actividad 3.20 Uso de variable if");
            Console.WriteLine("Programa para calcular el precio final de venta de una fabrica de pantalones");
            //Entrada
            Console.WriteLine("Ingrese el numero de los pantalones");
            NUMP = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del metro de tela");
            MTT = double.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona el valor de modelo.");
            Console.WriteLine("\t1.- A");
            Console.WriteLine("\t2.- B");
            Console.Write("\t: ");
            //Proceso y salida
            do
            {
                MODEL = int.Parse(Console.ReadLine());
                if (MODEL < 1 || MODEL > 2)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (MODEL < 1 || MODEL > 2);
            Console.WriteLine("Selecciona el valor de talla.");
            Console.WriteLine("\t1.- 30");
            Console.WriteLine("\t2.- 32");
            Console.WriteLine("\t3.- 36");
            Console.Write("\t: ");
            do
            {
                TALLA = int.Parse(Console.ReadLine());
                if (TALLA < 1 || TALLA > 3)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (TALLA < 1 || TALLA > 3);
            if (MODEL == 1)
                MTST = 1.5 * NUMP;
            else
                MTST = 1.8 * NUMP;
            CT = MTST * MTT;
            if (MODEL == 1)
                MO = CT * 0.8;
            else
                MO = CT * 0.95;
            if (TALLA == 2 || TALLA == 3)
                CARGOT = MO * 0.04;
            else
                CARGOT = 0;
            GAX= (CT + MO + CARGOT) * 0.30;
            PF = CT + MO + CARGOT + GAX;
            GA = CARGOT + GAX;
            Console.WriteLine("El valor del cargo por talla es de: " + CARGOT);
            Console.WriteLine("El valor del costo de la tela es de: " + CT);
            Console.WriteLine("La ganancia es de: " + GA);
            Console.WriteLine("La ganancia extra es de: " + GAX);
            Console.WriteLine("EL valor de mano de obra es de: " + MO);
            Console.WriteLine("El valor de metros de tela es de: " + MTST);
            Console.WriteLine("El precio final es de: " + PF);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
