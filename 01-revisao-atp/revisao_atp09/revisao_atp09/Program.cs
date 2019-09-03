using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp09
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] % 3 == 0) cont++;
            }
            Console.WriteLine("Quantidade de Numeros multiplos de 3: {0}",cont+1);
            Console.ReadLine();
        }
    }
}
