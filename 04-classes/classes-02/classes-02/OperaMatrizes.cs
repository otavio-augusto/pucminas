using classes_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_02
{
    class OperaMatrizes : Matrizes
    {
        public OperaMatrizes(bool randomizar) : base(randomizar)
        {
            
        }

        public OperaMatrizes(int n, int p, bool randomizar) : base(n, p, randomizar)
        {

        }

        public OperaMatrizes()
        {

        }

        public Matrizes multiplicar(Matrizes x, Matrizes y)
        {
            int[,] mul = new int[x.N, x.P];
            for (int i = 0; i < x.N; i++)
            {
                for (int j = 0; j < x.P; j++)
                {
                    mul[i, j] = x.Matriz[i, j] * y.Matriz[i, j];
                }
            }
            Matrizes resultado = new Matrizes(x.N, x.P, mul);
            return resultado;
        }
    }
}
