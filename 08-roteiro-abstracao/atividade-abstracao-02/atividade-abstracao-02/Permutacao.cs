using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao_02
{
    class Permutacao : IAnaliseCombinatoria
    {

        public double calcular(int N, int P = 0)
        {
            return fatorial(N);
        }

        public double fatorial(int n)
        {
            double resultado = 0;
            for (int i = (int)n - 1; i > 0; i--)
            {
                resultado += n * i;
            }
            return resultado;
        }
    }
}
