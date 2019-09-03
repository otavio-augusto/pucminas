using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp07
{
    class Program
    {
        static void Main(string[] args)
        {
            float arvoreA = 0.8f, arvoreB = 1.3f;
            int cont = 0;
            while (arvoreA < arvoreB)
            {
                arvoreA += 0.12f;
                arvoreB += 0.08f;
                cont++;
            }
            Console.WriteLine("A árvore A demorou {0} anos para passar a árvore B.",cont+1);
            Console.ReadKey();
        }
    }
}
