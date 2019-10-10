using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Escolha Um Numero.:");
            numero.acharPrimos(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
