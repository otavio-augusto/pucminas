using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_class
{
    class Program
    {
        class Aluno
        {
            public int matricula;
            public string nome;
            public string nascimento;
        }
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[3];

            for (int i = 0; i < 3; i++)
            {
                Aluno aluno = new Aluno();
                Console.Write("Matricula..: "); aluno.matricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome.......: "); aluno.nome = Console.ReadLine();
                Console.Write("Nascimento.: "); aluno.nome = Console.ReadLine();
                alunos[i] = aluno;
            }

            foreach (Aluno x in alunos)
            {
                Console.Write("{0} - {1} \n",x.matricula, x.nome);
            }

            Console.ReadKey();
        }
    }
}
