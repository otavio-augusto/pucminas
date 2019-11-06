using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_forms_02
{
    class Conta
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int[] saque(double valor)
        {
            double aux = valor;
            if (valor > Saldo)
            {
                MessageBox.Show("Saldo Insuficiente!");
            }
            else
            {
                    int notas50 = 0, notas20 = 0, notas10 = 0, notas5 = 0;
                    while (valor >= 50)
                    {
                        notas50++;
                        valor -= 50;
                    }
                    while (valor > 20)
                    {
                        notas20++;
                        valor -= 20;
                    }
                    while (valor > 10)
                    {
                        notas10++;
                        valor -= 10;
                    }
                    while (valor > 5)
                    {
                        notas5++;
                        valor -= 5;
                    }
                if (valor == 0)
                {
                    Saldo -= aux;
                    return new int[] { notas50, notas20, notas10, notas5 };
                }
                else
                    return null;
            }
            return null;
        }

        public bool contarNotas(double valor)
        {
            int notas50 = 0, notas20 = 0, notas10 = 0, notas5 = 0;
            while (valor > 50)
            {
                notas50++;
                valor -= 50;
            }
            while (valor > 20)
            {
                notas20++;
                valor -= 20;
            }
            while (valor > 10)
            {
                notas10++;
                valor -= 10;
            }
            while (valor > 5)
            {
                notas5++;
                valor -= 5;
            }
            if (valor != 0)
                return false;
            else
                return true;
        }

    }
}
