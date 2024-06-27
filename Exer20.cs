using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            string primo = isPrimo(n1) ? $"{n1} é primo" : $"{n1} não é primo";

            Console.WriteLine(primo);
        }
        public static bool isPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else if (num == 2)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
    

