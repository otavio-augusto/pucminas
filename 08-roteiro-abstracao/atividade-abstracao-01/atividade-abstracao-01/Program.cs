using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor de N: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de P: "); int p = int.Parse(Console.ReadLine());

            Permutacao permutacao = new Permutacao();
            Console.WriteLine("Permutação.: {0}", permutacao.calcular(n));

            Arranjo arranjo = new Arranjo();
            Console.WriteLine("Arranjo....: {0}", arranjo.calcular(n, p));

            Combinacao combinacao = new Combinacao();
            Console.WriteLine("Combinação.: {0}", combinacao.calcular(n, p));

            Console.ReadKey();
        }
    }
}
