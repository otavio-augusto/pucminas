using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_funcionario
{
    class AumentoSalarial
    {
        private Estrategia estrategia;

        public Estrategia Estrategia
        {
            get { return estrategia; }
            set { estrategia = value; }
        }

        public double executarEstrategia(double salario)
        {
            double salarioFinal;
            salarioFinal = Estrategia.executar(salario);
            return salarioFinal;
        }

    }
}
