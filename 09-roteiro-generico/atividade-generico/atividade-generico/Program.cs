using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_generico
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor<int> vetorINT = new Vetor<int>(10);
            Random random = new Random();

            for (int i = 0; i < vetorINT.Tamanho; i++)
            {
                vetorINT[i] = random.Next(1, 101);
            }

            vetorINT.listarDados();
            Console.ReadKey();
        }
    }
}
