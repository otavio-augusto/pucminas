using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao_01
{
    public abstract class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        private double perimetro;
        private double area;

        public double Perimetro
        {
            get { return calcularPerimetro(); }
        }

        public double Area
        {
            get { return calcularArea(); }
        }

        public abstract double calcularArea();
        public virtual double calcularPerimetro()
        {
            return A + B + C;
        }
    }

    class Retangulo : Triangulo
    {
        
        public override double calcularArea()
        {
            double hipotenusa = A, cateto1 = B, cateto2 = C;
            if (B > hipotenusa)
            {
                hipotenusa = B;
                cateto1 = A;
                cateto2 = C;
            }
            else if (C > hipotenusa)
            {
                hipotenusa = C;
                cateto1 = A;
                cateto2 = B;
            }

            return (cateto1 * cateto2) / 2f;
        }
    }

    class Isoceles : Triangulo
    {
        public override double calcularArea()
        {
            double diferente, hipotenusa;
            if (B == C)
            {
                diferente = A;
                hipotenusa = B;
            } else if (A == C)
            {
                diferente = B;
                hipotenusa = A;
            } else
            {
                diferente = C;
                hipotenusa = A;
            }
            double cateto = diferente / 2f;
            double altura = Math.Sqrt(Math.Pow(hipotenusa, 2) + Math.Pow(cateto, 2));
            return (cateto * altura);
        }
    }
    class Equilatero : Triangulo
    {
        public override double calcularArea()
        {
            double altura = Math.Sqrt(Math.Pow(A/2, 2) + Math.Pow(A, 2));
            return A * altura;
        }
    }
}
