using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Exer06
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("digite algo:");
            string texto = Console.ReadLine().ToLower();

            int qtdVogais = ContarVogais(texto);
            Console.WriteLine($"a frase {texto} tem {qtdVogais} vogais");

        }
        public static int ContarVogais(string txt)
        {
            int vogais = 0;
            
                char[] quebraString = txt.ToCharArray();
               
                foreach (char c in quebraString)
                {
                    switch (c)
                    {
                        case 'a':
                            vogais++;
                            break;
                        case 'e':
                            vogais++;
                            break;
                        case 'i':
                            vogais++;
                            break;
                        case 'o':
                            vogais++;
                            break;
                        case 'u':
                            vogais++;
                            break;
                    }
                }
                return vogais;
            
        }
    }
}
