using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            numero.ler();
            numero.resultado();
            Console.ReadKey();
        }
    }
}
