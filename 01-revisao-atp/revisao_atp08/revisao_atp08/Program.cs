using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            String num = Console.ReadLine();
            String parte1 = num.Substring(0, 2);
            String parte2 = inverter(num.Substring(2, 2));

            if (parte1 == parte2) Console.WriteLine("Numero é palindromo");
            else Console.WriteLine("Não é palindromo");

            Console.ReadKey();
        }

        public static string inverter(string frase)
        {
            char[] inverso = frase.ToCharArray();
            Array.Reverse(inverso);
            return new string(inverso);
        }
    }
}
