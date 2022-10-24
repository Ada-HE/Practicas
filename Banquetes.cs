using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3._6._1
{ 
 class program
{
    static void Main(string[] args)
    {
        //Declarar variables
        int CP, NP;
        double PRE;

        Console.WriteLine("Eejmplo 3.6 Uso de variable if");
        Console.WriteLine("Programa para calcular el costo de platillo por persona");
        //Entrada
        Console.WriteLine("Ingrese la cantidad de personas");
        NP = int.Parse(Console.ReadLine());
            //Proceso y salida
            CP = 95;
        if (NP > 200 && NP <=300)
        {
            CP = 85;
        }
        if (NP > 300)
        {
            CP = 75;
        }
            PRE = CP * NP;
        Console.WriteLine("El presupuesto sera de:" + PRE);
        Console.ReadKey();
    }
}
}

