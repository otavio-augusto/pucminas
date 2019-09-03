using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];
            int[] y = new int[3];
            float soma1 = 0, soma2 = 0;
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                x[i] = random.Next(100);
                y[i] = random.Next(100);
            }

            for (int i = 0; i < 3 ; i++)
            {
                soma1 += x[i];
                soma2 += y[i];
            }

            Console.WriteLine("Resultado do Vetor 1:  {0} \nResultado do Vetor 2:  {1}",soma1,soma2);
            Console.WriteLine("Diferença dos Vetores: {0}",(soma1-soma2));
            Console.ReadKey();
        }
    }
}
