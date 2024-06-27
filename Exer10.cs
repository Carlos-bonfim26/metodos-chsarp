using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade de avaliações feitas para compor a nota:");
           int avaliacoes = Convert.ToInt32(Console.ReadLine());
            MediaPonderada(avaliacoes);
        }
        static void MediaPonderada(int n)
        {
            double[] pesos = new double[n];
            double[] notas = new double[n];
            double acumulador = 0;
            double mediaFinal;
            for (int i = 0; i < pesos.Length; i++)
            {
                Console.WriteLine($"digite o peso da {i + 1}° nota:");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < notas.Length; i++)
            {

                Console.WriteLine($"digite a {i + 1}° nota:");
                notas[i] = Convert.ToDouble(Console.ReadLine()) * pesos[i];

                acumulador += notas[i];
            }
            mediaFinal = acumulador / pesos.Sum();
            Console.WriteLine($"a média é {Math.Round(mediaFinal, 2)}");
        }
    }
}
