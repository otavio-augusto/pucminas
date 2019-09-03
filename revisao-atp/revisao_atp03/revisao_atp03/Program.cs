using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 0; i <= 1000; i++)
            {
                float soma = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0) soma += j;
                }
                if (soma == i) Console.Write("{0,4} \t", i);
            }
            Console.ReadKey();
        }
    }
}
