using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao_01
{
    public abstract class AnaliseCombinatoria
    {
        public double fatorial(double num)
        {
            double resultado = 0;
            for (int i = (int)num - 1; i > 0; i--)
            {
                resultado += num * i;
            }
            return resultado;
        }

        public abstract double calcular(int n, int p = 0);
    }
}
