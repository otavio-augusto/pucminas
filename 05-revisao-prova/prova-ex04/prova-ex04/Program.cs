using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dados = new ArrayList();
            dados.Add(new Funcionario("Adalberto", "Rua A", "123123123", "abc123456", 2500));
            dados.Add(new Professor("Bdalberto", "Rua B", "456456456", "abc56789", 2500, "Perna"));

            foreach (Funcionario funcionario in dados)
            {
                if(funcionario is Funcionario)
                {
                    funcionario.listar();
                } else if(funcionario is Professor professor)
                {
                    professor.listar();
                }
            }

            Console.ReadKey();
        }
    }
}
