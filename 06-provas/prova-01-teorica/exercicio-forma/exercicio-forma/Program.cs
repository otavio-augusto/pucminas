using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_forma
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.Lado = 4;
            quadrado.mensagem();
            Console.WriteLine("Area do Quadrado......: {0:F2}", quadrado.Area);
            Console.WriteLine("Perimetro do Quadrado.: {0:F2}", quadrado.Perimetro);
            Circulo circulo = new Circulo();
            circulo.Raio = 4;
            circulo.mensagem();
            Console.WriteLine("Area do Circulo......: {0:F2}", circulo.Area);
            Console.WriteLine("Perimetro do Circulo.: {0:F2}", circulo.Perimetro);
            Console.ReadKey();
        }
    }
}
