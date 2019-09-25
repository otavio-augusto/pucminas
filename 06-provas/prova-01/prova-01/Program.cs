using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados(100);
            Funcionario funcionario = new Funcionario();
            for (int i = 0; i < dados.Tamanho; i++)
            {
                dados[i] = new Funcionario().cadastrar();
                Console.Clear();
            }
            dados.relatorio();
            Console.ReadKey();
        }
    }
}
