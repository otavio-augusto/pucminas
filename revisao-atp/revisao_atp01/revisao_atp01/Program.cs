using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float soma = 0;
            Console.Write("Numero de iterações: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0, x = 1, y = 2; i < n; i++, soma += (float)x++ / (float)y++) ;
            Console.WriteLine("Resultado: {0}",soma);
            Console.ReadKey();
        }
    }
}
