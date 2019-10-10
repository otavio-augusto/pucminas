using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_primo
{
    class Numero : Primo
    {
        public void acharPrimos(int numero)
        {
            int acima = base.primoAcima(numero), abaixo = base.primoAbaixo(numero);
            if (abaixo == -1) Console.WriteLine("Nenhum numero primo abaixo!");
            else
                Console.WriteLine("Primo Abaixo.: {0}", abaixo);
            Console.WriteLine("Primo Acima..: {0}", acima);
        }
    }
}
