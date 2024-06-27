using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer14
    {
        public static void Main(string[] args)
        {
            int[] nota = new int[3];

            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine($"digite a {i + 1}° nota:");
                nota[i] = Convert.ToInt32(Console.ReadLine()); 

            }
            float resMedia = media(nota[0], nota[1], nota[2]);

            Console.WriteLine($"a média das nota é {resMedia}");
        }
        public static float media(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
    }
}
