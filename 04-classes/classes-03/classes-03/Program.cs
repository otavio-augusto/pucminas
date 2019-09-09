using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();
            Times times = new Times();
            do
            {
                Console.Clear();
                Console.Write("Menu:\n1 - Adicionar Time\n2 - Listar Times: ");
                switch (Console.ReadLine()[0])
                {
                    case '1':
                        dados[dados.Index] = times.cadastrar();
                        break;
                    case '2':
                        foreach (Times time in dados.Dado)
                        {
                            time.listar();
                        }
                        break;
                }
                Console.WriteLine("Continuar? (ESC para sair): ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
