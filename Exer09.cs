using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer09
    {
        public static void Main(string[] args)
        {
            int[] lado = new int[3];

            for (int i = 0; i < lado.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° lado do triângulo:");
                lado[i] = Convert.ToInt32(Console.ReadLine());
            }
            string isTriangulo = triangulo(lado[0], lado[1], lado[2]) ? "é um triângulo" : "não é um triângulo";

            Console.WriteLine(isTriangulo);
        }
        public static bool triangulo(int l1, int l2, int l3)
        {
            if (l1 > l2 + l3 || l2 > l3 + l1|| l3 > l2 + l1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
