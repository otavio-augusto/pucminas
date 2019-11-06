using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao_02
{
    class Calculo
    {
        public double executarCalculo(IAnaliseCombinatoria analiseCombinatoria, int n, int p)
        {
            return analiseCombinatoria.calcular(n, p);
        }
    }
}
