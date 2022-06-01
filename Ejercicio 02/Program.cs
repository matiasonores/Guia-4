using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite 20 números y calcule y emita por pantalla
         //cuántos son positivos(mayores a cero).Se debe mostrar un solo valor: el
         //conteo final.

         int n, positivos = 0;

         Console.WriteLine("Por favor, ingrese 20 números.");

         for (int i = 0; i < 20; i++)
         {
            n = int.Parse(Console.ReadLine());

            if (n > 0)
               positivos ++;
         }
         Console.WriteLine("La cantidad de números positivos fue: {0}", positivos);
         Console.ReadKey();
      }
   }
}
