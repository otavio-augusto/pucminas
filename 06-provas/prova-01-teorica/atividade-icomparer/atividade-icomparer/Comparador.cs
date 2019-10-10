using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_icomparer
{
    class Comparador : iComparador
    {
        public int Comparar(int x, int y)
        {
            if (x == y)
                return 0;
            else if (x<y) 
                    return -1;
            else
                return 1;
        }
    }
}
