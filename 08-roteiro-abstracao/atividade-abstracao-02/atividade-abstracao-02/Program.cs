using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor de N: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de P: "); int p = int.Parse(Console.ReadLine());

            Calculo calculo = new Calculo();
            Console.WriteLine("Permutação.: {0}", calculo.executarCalculo(new Permutacao(), n, p));

            Arranjo arranjo = new Arranjo();
            Console.WriteLine("Arranjo....: {0}", calculo.executarCalculo(new Arranjo(), n, p));

            Combinacao combinacao = new Combinacao();
            Console.WriteLine("Combinação.: {0}", calculo.executarCalculo(new Combinacao(), n, p));

            Console.ReadKey();
        }
    }
}
