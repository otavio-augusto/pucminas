using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_forms_04
{
    class Soma : IOperacao
    {
        public double calcular(double x, double y)
        {
            return x + y;
        }
    }
}
