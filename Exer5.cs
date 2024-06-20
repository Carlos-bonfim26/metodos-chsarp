using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("escreva algo:");
            string frase = Console.ReadLine();
            string invertida = Inverter(frase);

            Console.WriteLine($"frase original: {frase}, frase invertida:{invertida}");
        }
        static string Inverter(string str)
        {
            char[] quebraString = str.ToCharArray();
            Array.Reverse(quebraString);
            return new string(quebraString);
        }
    }
}
