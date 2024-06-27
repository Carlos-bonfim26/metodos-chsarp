using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite um expoente inteiro:");
            int expoente = Convert.ToInt32(Console.ReadLine());

            int resPotencia = potencia(numero, expoente);

            Console.WriteLine($"{numero} ^ {expoente} = {resPotencia}");
        }
        public static int potencia(int n, int e)
        {
            int i = 0, acumulador = 1;

            while(i < e)
            {
                acumulador *= n;
                i++;
            }
            return acumulador;
        }
    }
}
