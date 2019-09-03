using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Filme[] filme = new Filme[5];
            for (int i = 0; i < filme.Length; i++)
            {
                filme[i] = new Filme();
                Console.WriteLine("Filme {0}", i + 1);
                Console.Write("Nome......: "); filme[i].Nome = Console.ReadLine();
                Console.Write("Duração...: "); filme[i].Duracao = Console.ReadLine();
                Console.Write("Diretor...: "); filme[i].Diretor = Console.ReadLine();
                Console.Write("Categoria.: "); filme[i].Categoria = Console.ReadLine();
                Console.Clear();
            }

            for (int i = 0; i < filme.Length; i++)
            {
                Console.WriteLine("Filme {0}", i + 1);
                Console.WriteLine("Nome......: {0}", filme[i].Nome);
                Console.WriteLine("Duração...: {0}", filme[i].Duracao);
                Console.WriteLine("Diretor...: {0}", filme[i].Diretor);
                Console.WriteLine("Categoria.: {0} \n", filme[i].Categoria);
            }
            Console.ReadKey();
            Console.Clear();
            Console.Write("Escolha uma Categoria: "); String categoria = Console.ReadLine();
            for (int i = 0; i < filme.Length; i++)
            {
                if (filme[i].isMesmaCategoria(categoria))
                {
                    Console.WriteLine("Filme {0}", i + 1);
                    Console.WriteLine("Nome......: {0}", filme[i].Nome);
                    Console.WriteLine("Duração...: {0}", filme[i].Duracao);
                    Console.WriteLine("Diretor...: {0}", filme[i].Diretor);
                    Console.WriteLine("Categoria.: {0} \n", filme[i].Categoria);
                }
            }
            Console.ReadKey();
        }
    }
}

