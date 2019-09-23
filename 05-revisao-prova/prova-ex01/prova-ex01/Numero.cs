using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_ex01
{
    class Numero
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                if (x < 0) {
                    x = 0;
                }
                else {
                    x = value;
                }
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (y < 0) {
                    y = 0;
                }
                else {
                    y = value;
                }
            }
        }

        public void ler()
        {
            Console.Write("Primeiro Numero.: "); X = int.Parse(Console.ReadLine());
            Console.Write("Segundo Numero..: "); Y = int.Parse(Console.ReadLine());
        }
        public void resultado()
        {
            Console.Write(
                "Soma..........: {0}\n" +
                "Subtração.....: {1}\n" +
                "Multiplicação.: {2}\n" +
                "Divisão.......: {3}\n",somar(),subtrair(),multiplicar(),dividir());
        }

        public int somar() { return (Y + X); }
        public int subtrair() { return X - Y; }
        public int multiplicar() { return X * Y; }
        public int dividir() {
            if (Y != 0) return (X / Y);
            else return -1;
        }

    }
}
