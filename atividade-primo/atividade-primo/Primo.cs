using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_primo
{
    class Primo : IPrimo
    {
        public int primoAbaixo(int numero)
        {
            for (int i = numero - 1; i >= 2; i--)
            {
                if (isPrimo(i))
                {
                    return i;
                }
            }
            return -1;
        }

        public int primoAcima(int numero)
        {
            while(true)
            {
                if (isPrimo(++numero))
                {
                    return numero;
                }
            }
        }

        public bool isPrimo(int numero)
        {
            for (int i = numero -1; i >= 2; i--)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
