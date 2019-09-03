using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_atp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = random.Next(100);
                }
            }
            Console.WriteLine("Soma dos numeros abaixo da diagonal: {0}",somaDiagonal(matriz));
            Console.ReadKey();
        }

        public static float somaDiagonal(int[,] matriz)
        {
            float soma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i > j) soma += matriz[i, j];
                }
            }
            return soma;
        }
    }
}
