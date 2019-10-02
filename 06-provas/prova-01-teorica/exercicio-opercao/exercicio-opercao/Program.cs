using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_opercao
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y, resultado;
            Console.Write("X: "); x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: "); y = Convert.ToDouble(Console.ReadLine());
            resultado = escolherOperacao(new Soma(), x, y);
            Console.WriteLine("Soma......: {0:F2}", resultado.ToString());
            resultado = escolherOperacao(new Subtracao(), x, y);
            Console.WriteLine("Subtração.: {0:F2}", resultado.ToString());
            Console.ReadKey();
        }

        static double escolherOperacao(Operacao operacao, double x, double y)
        {
            return operacao.calcular(x, y);
        }
    }
}
