using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite algum ano:");
            int ano = Convert.ToInt32(Console.ReadLine());

            string isBisexto = anoBisexto(ano)? $"{ano} foi um ano bisexto" : $"{ano} não foi um ano bisexto";

            Console.WriteLine(isBisexto);
        }
        public static bool anoBisexto(int ano)
        {
            if (ano % 4 == 0 && ano % 100 != 0)
            {
                return true;
            }
            else if (ano % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
