using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{numero}² = {aoquadrado(numero)}");
        }
        public static int aoquadrado(int num)
        {
            return num * num;

        }
    }
}
