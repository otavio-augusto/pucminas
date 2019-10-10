using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_icomparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor vetor = new Vetor();
            vetor.listar();
            vetor.ordenar(new Comparador());
            vetor.listar();
            Console.Write("\nNumero desejado: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int pos = vetor.buscaBinaria(new Comparador(), numero);
            if(pos <0)
                Console.WriteLine("Numero não encontrado");
            else
                Console.WriteLine("Encontrado não posição: {0}", pos);
        }
    }
}
