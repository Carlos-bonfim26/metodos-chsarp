using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(verificar(numero));
        }
        public static string verificar(int numero)
        {
            if (numero == 0)
            {
                return "zero";
            }
            else if (numero > 0)
            {
                return $"{numero} é positivo";
            }
            else
            {
                return $"{numero} é negativo";
            }
        }   
    }
}
