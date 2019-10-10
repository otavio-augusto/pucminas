using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_forms
{
    class Equacao
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        private double delta;

        public double Delta
        {
            get
            {
                return Math.Pow(B,2) - 4 * A * C;
            }
            set { delta = value; }
        }

        private double raiz1;

        public double Raiz1
        {
            get
            {
                return (-B + Math.Sqrt(Delta)) / 2 * A;
            }
            set { raiz1 = value; }
        }

        private double raiz2;

        public double Raiz2
        {
            get
            {
                return (-B - Math.Sqrt(Delta)) / 2 * A; ;
            }
            set { raiz2 = value; }
        }
    }
}
