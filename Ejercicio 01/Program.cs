using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite el ingreso de 10 números y que muestre el
         //mayor de ellos por pantalla.Solo se debe emitir UN valor por pantalla.

         int n,mayor=0;

         Console.WriteLine("Por favor, ingrese 10 números (mayores a 0)");

         for (int i = 0;i<10; i++)
         {
            n=int.Parse(Console.ReadLine());

            if (n > mayor)
               mayor = n;
         }
         Console.WriteLine("El número ingresado más grande fue: {0}", mayor);
         Console.ReadKey();
      }
   }
}
