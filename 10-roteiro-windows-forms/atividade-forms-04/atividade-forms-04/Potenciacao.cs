using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_forms_04
{
    class Potenciacao : IOperacao
    {
        public double calcular(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
