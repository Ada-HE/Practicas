﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            char opcion, operador= ' ';
            //Declarando e inicializando variables
            //se asigna el valor de 0 a las variables
            double num1 = 0, num2 = 0, resultado = 0;
            Console.WriteLine("Calculadora basica");
            Console.WriteLine("Selecciona una opcion:");
            Console.WriteLine("S-Suma");
            Console.WriteLine("R-Resta");
            Console.WriteLine("D-Division");
            Console.WriteLine("M-Multiplicacion");
            Console.WriteLine("Selecciona una opcion: ");
            opcion= char.Parse(Console.ReadLine());
            if(opcion=='S' || opcion== 'R' || opcion=='M' || opcion=='D')
            {
            Console.WriteLine("Ingresa el primer numero:");
            num1= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero: ");
            num2=double.Parse(Console.ReadLine());
            //realiza la operacion segun la opcion
            switch (opcion)
            {
                case 'S':
                        resultado = num1 + num2;
                        operador = '+';
                        break;
                case 'R':
                        resultado = num1 - num2;
                        operador = '-';
                        break;
                case 'D':
                        resultado = num1 / num2;
                        operador = '/';
                        break;
                case 'M':
                        resultado = num1 * num2;
                        operador = '*';
                        break;
            }  
             //salida
             Console.WriteLine( num1 + " " + operador + " " + num2 +  " " + "=" + resultado );
            }
            else
            {
               Console.WriteLine("Verificar la opcion: ");
            }
               Console.ReadKey();
        }
    }
}
