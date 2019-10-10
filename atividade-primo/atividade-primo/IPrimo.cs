using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_primo
{
    interface IPrimo
    {
        int primoAcima(int numero);
        int primoAbaixo(int numero);
        bool isPrimo(int numero);
    }
}
