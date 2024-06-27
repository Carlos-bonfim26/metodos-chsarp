using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer03
    {
        public static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Digite uma palavra:");
                input = Console.ReadLine();
            } while (input == null || input == "");
            string palindromo = VerificarPalindromo(input) == true ? $"{input} é um palindromo" : $"{input} não é um palindromo";
            Console.WriteLine(palindromo);



        }

        static string Inverter(string str)
        {
            
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static bool VerificarPalindromo(string str)
        {
            string reverso = Inverter(str);

            if (RemoverEspacos(str.ToLower()) == RemoverEspacos(reverso.ToLower()))
            {
                return true;
            }
            else
            {
                {
                    return false;
                }
            }
        }
        static string RemoverEspacos(string str)
        {
            return new string(str.Where(c => !char.IsWhiteSpace(c)).ToArray());
        }
    }
}
