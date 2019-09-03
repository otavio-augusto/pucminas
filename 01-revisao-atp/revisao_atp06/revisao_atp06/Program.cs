using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = new int[10];
            int[] s = new int[10];
            int[] v = new int[20];
            int control = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                r[i] = random.Next(100);
                s[i] = random.Next(100);
            }

            adicionar(ref r, ref v, ref control);
            adicionar(ref s, ref v, ref control);

            Console.WriteLine("Vetor Resultante: ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("| {0,3} ",v[i]);
            }

            Console.ReadKey();
        }

        public static void adicionar(ref int[]vetor, ref int[]s, ref int controle)
        {
            for (int i = 0; i < 10; i++)
            {
                bool contem = false;
                for (int j = 0; j < 10; j++)
                {
                    if (vetor[i] == s[j]) contem = true;
                    break;
                }
                if (!contem)
                {
                    s[controle++] = vetor[i];
                }
            }
        }
    }
}
