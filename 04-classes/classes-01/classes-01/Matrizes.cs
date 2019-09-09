using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_01
{
    class Matrizes
    {
        private int[,] matriz;
        private int n, p;
        public Matrizes(bool randomizar)
        {
            this.matriz = new int[3, 3];
            this.n = 3;
            this.p = 3;
            lerValores(randomizar);
        }
        public Matrizes(int n, int p, bool randomizar)
        {
            this.matriz = new int[n, p];
            this.n = n;
            this.p = p;
            lerValores(randomizar);
        }

        public void lerValores(bool randomizar)
        {
            switch (randomizar)
            {
                case true:
                    Console.Write("Limite Superior: "); int limitesup = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Limite Inferior: "); int limiteinf = Convert.ToInt32(Console.ReadLine());
                    Random random = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < p; j++)
                        {
                            this.matriz[i, j] = random.Next(limiteinf, limitesup);
                        }
                    }
                    break;
                case false:
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < p; j++)
                        {
                            Console.Write("Valor em [{0}][{1}]",i,j);
                            this.matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    break;
            }

        }

        public void listar()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write("{0,3}|",this.matriz[i,j]);
                }
                Console.Write('\n');
            }
        }
    }
}
