using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite 20 números y luego emitir por pantalla el
         //máximo de los números pares y el mínimo de los números impares.

         int n,max=0,min=0;
         bool par = true, impar = true;

         Console.WriteLine("Ingrese 20 números:");
         for(int i=0;i<10;i++)
         {
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
               if (par)
               {
                  max = n;
                  par = false;
               }
               else
               {
                  if (n > max)
                     max = n;

               }
            }
            else
            {
               if (impar) 
               { 
                  min = n;
                  impar = false; 
               }
               else
               {
                  if (n < min)
                     min = n;
               }
            }
            
         }
         Console.WriteLine("El mayor de los números pares es: {0}",max);
         Console.WriteLine("El menor de los números impares es: {0}",min);
         Console.ReadKey();
      }
   }
}
