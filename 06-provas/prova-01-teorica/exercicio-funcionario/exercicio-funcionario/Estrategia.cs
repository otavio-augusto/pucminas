using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_funcionario
{
    public abstract class Estrategia
    {
        public abstract double executar(double salario);
    }

    class AumentoN1 : Estrategia
    {
        public override double executar(double salario)
        {
            return salario + (salario * 0.02); // 2% de Aumento
        }
    }

    class AumentoN2 : Estrategia
    {
        public override double executar(double salario)
        {
            return salario + (salario * 0.04); // 4% de Aumento
        }
    }
}
