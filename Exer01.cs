using System;

namespace Metodos
{
    internal class Exer01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            string nPrimo = NumeroPrimo(numero) == true ? $"{numero} é primo" : $"{numero} não é primo";
            Console.WriteLine(nPrimo);
        }

        static bool NumeroPrimo(int num)
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
