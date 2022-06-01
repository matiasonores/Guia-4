using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
         //de aquellas personas mayores a 18 años.

         int edad,mayor=0;
         double promedio=0;

         Console.WriteLine("Ingrese 20 edades:");
         for (int i = 0; i < 20; i++)
         {
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
               promedio += edad;
               mayor++;
            }
         }
         Console.WriteLine("El promedio de edad es: {0}", promedio / mayor);
         Console.ReadKey();
      }
   }
}
