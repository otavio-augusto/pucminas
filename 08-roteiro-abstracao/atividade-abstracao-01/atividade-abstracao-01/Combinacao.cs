﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao_01
{
    class Combinacao : AnaliseCombinatoria
    {
        public override double calcular(int n, int p = 0)
        {
            return base.fatorial(n) / (base.fatorial(p) * fatorial(n-p));
        }
    }
}
