using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MVC
{
    class MinhaOrdenacao:IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            return((Aluno)x).Nome.CompareTo(((Aluno)y).Nome);
        }
    }
}
