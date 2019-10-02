using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_forma
{
    class Quadrado : Forma
    {
        public int Lado { get; set; }

        public override double calcularArea()
        {
            return Lado * Lado;
        }

        public override double calcularPerimetro()
        {
            return Lado * 4;
        }

        public override void mensagem()
        {
            base.mensagem();
            Console.WriteLine("Quadrado: ");
        }
    }
}
