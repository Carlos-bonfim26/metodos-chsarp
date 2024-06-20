using System;

namespace Metodos
{
    internal class Exer2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O fatorial de {numero} é {Fatorial(numero)}");
        }

        static long Fatorial(int num)
        {
           
            long acumulador = 1;
            for (int i = num; i > 1; i--)
            {
                acumulador *= i;
            }
            return acumulador;
        }
    }
}
