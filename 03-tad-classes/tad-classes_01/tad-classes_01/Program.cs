using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_01
{
    class Program
    {
        struct Aluno
        {
            public String nome;
            public String email;
            public String nascimento;
            public String telefone; //String caso cadastro contenha () ou -
        }
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome...............: "); aluno.nome = Console.ReadLine();
            Console.Write("Email..............: "); aluno.email = Console.ReadLine();
            Console.Write("Data de Nascimento.: "); aluno.nascimento = Console.ReadLine();
            Console.Write("Telefone...........: "); aluno.telefone = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Nome...............: {0}", aluno.nome);
            Console.WriteLine("Email..............: {0}", aluno.email);
            Console.WriteLine("Data de Nascimento.: {0}", aluno.nascimento);
            Console.WriteLine("Telefone...........: {0}", aluno.telefone);
            Console.ReadKey();
        }
    }
}
