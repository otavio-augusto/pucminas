using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_opercao
{
    public abstract class Operacao
    {
        public abstract double calcular(double x, double y);
    }

    public class Soma : Operacao
    {
        public override double calcular(double x, double y)
        {
            return x + y;
        }
    }

    public class Subtracao : Operacao
    {
        public override double calcular(double x, double y)
        {
            return x - y;
        }
    }

    public class Multiplicacao : Operacao
    {
        public override double calcular(double x, double y)
        {
            return x * y;
        }
    }

    public class Divisao : Operacao
    {
        public override double calcular(double x, double y)
        {
            return x / y;
        }
    }
}
