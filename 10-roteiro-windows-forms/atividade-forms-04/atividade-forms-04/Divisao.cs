using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_forms_04
{
    class Divisao : IOperacao
    {
        public double calcular(double x, double y)
        {
            try { //Em caso de divisão por zero
                return x / y;
            }
            catch (Exception) {
                return 0;
            }
        }
    }
}
