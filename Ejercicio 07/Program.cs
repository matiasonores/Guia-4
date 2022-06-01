using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite 10 números y luego mostrar por pantalla el
         //máximo de ellos y la posición en la que fue ingresado.

         int n, mayor=0,posicionMayor=0;

         Console.WriteLine("Ingrese 10 números:");
         for (int i =0;i<10;i++)
         {
            n = int.Parse(Console.ReadLine());

            if (i == 0)
               mayor = n;
            else if(n>mayor)
            {
               mayor = n;
               posicionMayor = i+1;
            }
         }
         Console.WriteLine("El número mayor fue: {0} y su posición fue: {1}", mayor, posicionMayor);
         Console.ReadKey();
      }
   }
}
