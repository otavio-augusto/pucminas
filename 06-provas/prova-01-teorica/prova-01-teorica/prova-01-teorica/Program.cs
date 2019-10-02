using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_01_teorica
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatorial fatorial = new Fatorial();
            Console.WriteLine("Fatorial de 5.......: {0}", fatorial.calcular(4));
            SuperFatorial superFatorial = new SuperFatorial();
            Console.WriteLine("Super Fatorial de 5.: {0}", superFatorial.calcular(4));
            Console.ReadKey();
        }
    }
}
