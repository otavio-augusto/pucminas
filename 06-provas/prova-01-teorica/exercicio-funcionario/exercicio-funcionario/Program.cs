using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            AumentoSalarial aumento = new AumentoSalarial();
            ArrayList cadastro = new ArrayList();
            do
            {
                Funcionario funcionario = new Funcionario();
                Console.Write("Nome....: "); funcionario.Nome = Console.ReadLine();
                Console.Write("Salario.: "); funcionario.Salario = Convert.ToDouble(Console.ReadLine());
                if (funcionario.Salario < 2000f)
                    aumento.Estrategia = new AumentoN2();
                else
                    aumento.Estrategia = new AumentoN1();
                funcionario.NovoSalario = aumento.Estrategia.executar(funcionario.Salario);
                cadastro.Add(funcionario);
                Console.WriteLine("ESC para Sair: ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.Clear();
            foreach (Funcionario x in cadastro)
            {
                Console.WriteLine("Nome...........: {0}", x.Nome);
                Console.WriteLine("Salario Antigo.: {0}", x.Salario);
                Console.WriteLine("Salario Novo...: {0}", x.NovoSalario);
            }
            Console.ReadKey();
        }
    }
}
