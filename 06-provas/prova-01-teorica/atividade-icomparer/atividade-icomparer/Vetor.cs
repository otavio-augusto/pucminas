using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_icomparer
{
    class Vetor
    {
        public int[] vetor { get; set; }
        public Vetor()
        {
            vetor = new int[10];
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 101);
            }
        }

        public void listar()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("|{0,3}", vetor[i]);
            }
        }

        public void ordenar(Comparador comparador)
        {
            int swap = 1;
            int i = 1, aux;
            while (i <= 10 && swap == 1)
            {
                swap = 0;
                for (int j = 0; j < 10-2; j++)
                {
                    if (comparador.Comparar(vetor[j], vetor[j + 1]) == 1)
                    {
                        swap = 1;
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
                i++;
            }
        }

        public int buscaBinaria(Comparador comparador, int valor)
        {
            bool achou = false;
            int inicio = 0, fim = 9, meio = (inicio + fim) / 2;
            while (inicio<= fim && !achou)
            {
                if(vetor[meio] == valor)
                    achou = true;
                else
                {
                    if (comparador.Comparar(valor, vetor[meio]) == -1)
                        fim = meio - 1;
                    else
                        inicio = meio + 1;
                }

                
            }
            if (!achou) return -1;
            else return 1;
        }
    }
}
