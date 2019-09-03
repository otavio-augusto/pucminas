using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_03
{
    class Program
    {
        struct Aluno
        {
            public String nome;
            public String email;
            public Data nascimento;
            public String telefone; //String caso cadastro contenha () ou -
        }
        struct Data
        {
            public int dia;
            public int mes;
            public int ano;
        }
        static void Main(string[] args)
        {
            Aluno[] aluno = new Aluno[50];

            for (int i = 0; i < aluno.Length; i++)
            {
                Console.Write("Aluno {0}", i + 1);
                Console.Write("Nome....................: "); aluno[i].nome = Console.ReadLine();
                Console.Write("Email...................: "); aluno[i].email = Console.ReadLine();
                Console.Write("Data de Nascimento - Dia: "); aluno[i].nascimento.dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Data de Nascimento - Mes: "); aluno[i].nascimento.mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Data de Nascimento - Ano: "); aluno[i].nascimento.ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Telefone................: "); aluno[i].telefone = Console.ReadLine();
                Console.Clear();
            }

            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine("Aluno {0}", i + 1);
                Console.WriteLine("Nome...............: {0}", aluno[i].nome);
                Console.WriteLine("Email..............: {0}", aluno[i].email);
                Console.WriteLine("Data de Nascimento.: {0}/{1}/{2}", aluno[i].nascimento.dia, aluno[i].nascimento.mes, aluno[i].nascimento.ano);
                Console.WriteLine("Telefone...........: {0}", aluno[i].telefone);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
