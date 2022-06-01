using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
         //de los primos de la lista. En caso de no haber ningún número primo, deberá
         //aclararlo con un cartel.

         bool primo = false;
         Console.WriteLine("Ingrese 10 números:");

         int n,mayor=0;

         for (int i = 0; i < 10; i++)
         {
            n = int.Parse(Console.ReadLine());
            for (int j = 2; j < n; j++)
            {

               if (n % j == 0)
                  primo = true;
            }

            if (primo)
               Console.WriteLine("No es primo");
            else
            {
               if (mayor == 0)
               {
                  mayor = n;
                  Console.WriteLine("Es primo");
               }
               else if (n > mayor)
               {     
                  mayor = n;
                  Console.WriteLine("Es primo");
               }
            } 
            
            primo = false;
         }
         Console.WriteLine("El mayor de los números primos es: {0}",mayor);
         Console.ReadKey();
      }
   }
}
