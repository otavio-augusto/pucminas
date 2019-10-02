using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_forma
{
    public abstract class Forma
    {
        private double area;
        private double perimetro;

        public double Area
        {
            get { return calcularArea(); }
        }
        public double Perimetro
        {
            get { return calcularPerimetro(); }
        }

        public abstract double calcularArea();
        public abstract double calcularPerimetro();
        public virtual void mensagem()
        {
            Console.Write("\nCalculando o ");
        }
    }
}
