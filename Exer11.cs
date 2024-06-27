using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número:"); 
            int numero = Convert.ToInt32(Console.ReadLine());

            string parOuImpar = isPar(numero) ? $"{numero} é par" : $"{numero} é ímpar";

            Console.WriteLine(parOuImpar);
        }
        public static bool isPar(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
