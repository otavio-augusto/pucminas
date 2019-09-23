using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_ex02
{
    class CVetor
    {
        Object[] vetor;
        public CVetor(int tamanho)
        {
            vetor = new Object[tamanho];
        }
        public CVetor()
        {
            Console.WriteLine("Tamanho do vetor: ");
            vetor = new Object[int.Parse(Console.ReadLine())];
        }
    }
}
