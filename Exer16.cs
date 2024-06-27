using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int res = maior(n1, n2);

            Console.WriteLine($"{res} é o maior número");
        }
        public static int maior(int x, int y)
        {
            if(x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
