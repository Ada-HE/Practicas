using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double Desc, PCD, Precio;
            Console.WriteLine("Actividad jueves 13 Uso de variable if");
            Console.WriteLine("Programa para calcular el descuento");
            //Entrada
            Console.WriteLine("Ingrese el precio del producto");
            Precio = double.Parse(Console.ReadLine());
            Desc = 0;
            PCD = 0;
            //Proceso y salida
            if (Precio <=0)
            {
                Desc = Precio * 0;
                PCD = Precio - Desc;
                Console.WriteLine("Verificar precio");
            }
            
            if (Precio >= 200)
            {
                Desc = Precio * 0.15;
                PCD = Precio - Desc;
                Console.WriteLine("El descuento realizado es de:" + Desc);
                Console.WriteLine("El Precio con descuento es de:" + PCD);
                Console.ReadKey();
            }
            if (Precio > 100 && Precio < 200)
            {
                Desc = Precio * 0.12;
                PCD = Precio - Desc;
                Console.WriteLine("El descuento realizado es de:" + Desc);
                Console.WriteLine("El Precio con descuento es de:" + PCD);
                Console.ReadKey();
            }

            if (Precio <=100 && Precio >=1)
            {
                Desc = Precio * 0.10;
                PCD = Precio - Desc;
                Console.WriteLine("El descuento realizado es de:" + Desc);
                Console.WriteLine("El Precio con descuento es de:" + PCD);
                Console.ReadKey();
            }
            
            Console.ReadKey();
        }
        
    }
}
