using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool somando = false;
            int n, soma = 100;
            Console.Write("Numero de iterações: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (somando)
                {
                    soma += i;
                    somando = false;
                }
                else
                {
                    soma -= i;
                    somando = true;
                }
            }
            Console.Write("Resultado: {0}",soma);
            Console.ReadKey();
        }
    }
}
