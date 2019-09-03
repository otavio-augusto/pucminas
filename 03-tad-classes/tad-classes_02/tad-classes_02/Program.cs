using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_02
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
            Aluno aluno = new Aluno();

            Console.Write("Nome....................: "); aluno.nome = Console.ReadLine();
            Console.Write("Email...................: "); aluno.email = Console.ReadLine();
            Console.Write("Data de Nascimento - Dia: "); aluno.nascimento.dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Data de Nascimento - Mes: "); aluno.nascimento.mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Data de Nascimento - Ano: "); aluno.nascimento.ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Telefone................: "); aluno.telefone = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Nome...............: {0}", aluno.nome);
            Console.WriteLine("Email..............: {0}", aluno.email);
            Console.WriteLine("Data de Nascimento.: {0}/{1}/{2}", aluno.nascimento.dia, aluno.nascimento.mes, aluno.nascimento.ano);
            Console.WriteLine("Telefone...........: {0}", aluno.telefone);
            Console.ReadKey();
        }
    }
}

