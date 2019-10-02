using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_01_teorica
{
    class Fatorial
    {
        private int num;
        public int Num
        {
            get { return num; }
            set {
                if (value < 0) num = 0;
                else num = value;
            }
        }
        public int calcular(int num)
        {
            this.Num = num;
            int resultado = 1;
            for (int i = 1; i <= Num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
    class SuperFatorial : Fatorial
    {
        private int num;
        public new int Num
        {
            get { return num; }
            set { num = value; }
        }
        public new int calcular(int num)
        {
            this.Num = num;
            int resultado = 1;
            for (int i = 1; i <= this.Num; i++)
            {
                resultado *= base.calcular(i);
            }
            return resultado;
        }
    }
}
