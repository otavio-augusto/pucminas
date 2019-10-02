using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_forma
{
    class Circulo : Forma
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double calcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double calcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override void mensagem()
        {
            base.mensagem();
            Console.WriteLine("Circulo: ");
        }
    }
}
