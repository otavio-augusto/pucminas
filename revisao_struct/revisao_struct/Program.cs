using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_struct
{
    struct Aluno
    {
        public int matricula;
        public string nome;
        public Data nascimento;
    }

    struct Data
    {
        public int dia;
        public int mes;
        public int ano;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno;
            aluno.matricula = 123456;
            aluno.nome = "Adalberto";
            aluno.nascimento.dia = 1;
            aluno.nascimento.mes = 1;
            aluno.nascimento.ano = 2001; //Structs compostos

            Console.WriteLine("{0} - {1}", aluno.matricula, aluno.nome);
            Console.WriteLine("{0}/{1}/{2} \n", aluno.nascimento.dia, aluno.nascimento.mes, aluno.nascimento.ano);
            Console.ReadKey();

            Aluno[] alunos = new Aluno[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Matricula: "); alunos[i].matricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome: "); alunos[i].nome = Console.ReadLine();

                Console.Write("Data de Nascimento - Dia: ");
                alunos[i].nascimento.dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Data de Nascimento - Mes: ");
                alunos[i].nascimento.mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Data de Nascimento - Ano: ");
                alunos[i].nascimento.ano = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Aluno em Vetor: \n");
            foreach (Aluno x in alunos)
            {
                Console.WriteLine("{0} - {1}", x.matricula, x.nome);
                Console.WriteLine("{0}/{1}/{2} \n", x.nascimento.dia, x.nascimento.mes,x.nascimento.ano);
            }
            Console.ReadKey();
        }
    }
}
