using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_5.TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum=0, i, prom;
            int [] num = new int[15];
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese un numero");
                num[i] = Int32.Parse(Console.ReadLine());

                acum = acum + num[i];

            }

            Array.Sort(num);
            prom= (acum/ 15);
            Console.WriteLine("El numero mayor es : {0}", num[14]);
            Console.WriteLine("El numero menor es : {0}", num[0]);
            Console.WriteLine("El promedio es: {0}", prom );

            Console.ReadKey();
        }
    }
}
