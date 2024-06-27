using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a base do retângulo:");
            float baseR = float.Parse(Console.ReadLine());
            Console.WriteLine("digite a altura do retângulo:");
            float altura = float.Parse(Console.ReadLine());

            float area = retangulo(baseR, altura);

            Console.WriteLine($"a altura do retângulo de base {baseR} e altura {altura} é igual a {area}");
        }
        public static int retangulo(int b, int h)
        {
            int area = b * h;

            return area;
        }
        public static float retangulo(float b, float h)
        {
            float area = b * h;

            return area;
        }
    }
}
