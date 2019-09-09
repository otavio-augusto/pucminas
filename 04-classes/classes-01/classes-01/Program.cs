using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrizes matrizes = new Matrizes(4 ,4 ,true);
            matrizes.listar();
            Console.ReadKey();
        }
    }
}
