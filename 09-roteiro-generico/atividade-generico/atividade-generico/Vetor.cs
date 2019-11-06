using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_generico
{
    class Vetor<T> : IEnumerable
    {
        public Vetor(int tamanho)
        {
            vetor = new T[this.tamanho = tamanho];
        }

        private T[] vetor;
        public T this[int i]
        {
            get { return vetor[i]; }
            set { vetor[i] = value; }
        }

        private int tamanho;
        public int Tamanho
        {
            get { return tamanho; }
        }
        public IEnumerator GetEnumerator()
        {
            return vetor.GetEnumerator();
        }
        public void listarDados()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0}\t",this[i]);
            }
        }
    }
}
