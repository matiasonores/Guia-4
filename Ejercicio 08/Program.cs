using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite 20 números y luego mostrar por pantalla el
         //menor de ellos y la posición en la que fue encontrado.

         int n, menor = 0, posicionMenor = 0;

         Console.WriteLine("Ingrese 20 números:");
         for (int i = 0; i < 20; i++)
         {
            n = int.Parse(Console.ReadLine());

            if (i == 0)
               menor = n;
            else if (menor>n)
            {
               menor = n;
               posicionMenor = i + 1;
            }
         }
         Console.WriteLine("El número menor fue: {0} y su posición fue: {1}", menor, posicionMenor);
         Console.ReadKey();
      }
   }
}
