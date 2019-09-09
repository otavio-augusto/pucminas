using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_03
{
    class Dados
    {
        private ArrayList dado;
        private int index;
        public Dados()
        {
            index = 0;
            Dado = new ArrayList();
        }

        public Object this[int i]
        {
            get { return Dado[i]; }
            set { Dado.Insert(i, value); }
        }

        public int Index { get => index++;}
        public ArrayList Dado { get => dado; set => dado = value; }
    }
}
