using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite UN número y luego calcule y emita un cartel
         //aclaratorio si el mismo es primo o no es primo.
         //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

         bool primo=false;
         Console.WriteLine("Ingrese un número para saber si es primo:");

         int n = int.Parse(Console.ReadLine());

         for(int i = 2; i<n;i++)
         {
            if(n%i==0)
               primo=true;
         }
         if (primo)
            Console.WriteLine("No es primo");
         else
            Console.WriteLine("Es primo");
         Console.ReadKey();
      }
   }
}
