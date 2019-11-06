using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_forms_04
{
    class Calculo
    {
        public double numero1 { get; set; }
        public double numero2 { get; set; }
        public IOperacao operacao { get; set; }

        public double calcular()
        {
            return operacao.calcular(numero1, numero2);
        }
    }
}
