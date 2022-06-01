using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.

         int n=1;

         for(int i = 0; i<10;i++)
         {
            Console.WriteLine(n);
            n += 1;
         }
         Console.ReadKey();
      }
   }
}
