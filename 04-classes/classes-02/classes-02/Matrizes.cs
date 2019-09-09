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
            this.Matriz = new int[3, 3];
            this.N = 3;
            this.P = 3;
            lerValores(randomizar);
        }
        public Matrizes(int n, int p, bool randomizar)
        {
            this.Matriz = new int[n, p];
            this.N = n;
            this.P = p;
            lerValores(randomizar);
        }
        public Matrizes(int n, int p, int[,] matriz)
        {
            this.Matriz = matriz;
            this.N = n;
            this.P = p;
        }
        public Matrizes()
        {

        }

        public int[,] Matriz { get => matriz; set => matriz = value; }
        public int N { get => n; set => n = value; }
        public int P { get => p; set => p = value; }

        public void lerValores(bool randomizar)
        {
            switch (randomizar)
            {
                case true:
                    Console.Write("Limite Superior: "); int limitesup = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Limite Inferior: "); int limiteinf = Convert.ToInt32(Console.ReadLine());
                    Random random = new Random();
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < P; j++)
                        {
                            this.Matriz[i, j] = random.Next(limiteinf, limitesup);
                        }
                    }
                    break;
                case false:
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < P; j++)
                        {
                            Console.Write("Valor em [{0}][{1}]",i,j);
                            this.Matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    break;
            }

        }

        public void listar()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    Console.Write("{0,4}|",this.Matriz[i,j]);
                }
                Console.Write('\n');
            }
            Console.WriteLine('\n');
        }
    }
}
