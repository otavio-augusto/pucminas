using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace MVC
{
    class Operações
    {
        private Dados MeusDados;
        public Operações(Dados D)
        {
            MeusDados = D;
        }
        public void Inserir(Aluno MeuAluno)
        {            
            do
            {

                MeuAluno = new Aluno();
                Console.Clear();
                Console.WriteLine("Cadastramento de Aluno");
                Console.WriteLine("======================\n");
                Console.WriteLine("Código................: {0}", MeuAluno.Codigo);
                Console.Write    ("Nome do Aluno.........: ");
                MeuAluno.Nome = Console.ReadLine();
                Console.Write("Telefone..............: ");
                MeuAluno.Telefone = Console.ReadLine();
                Console.Write("Mail..................: ");
                MeuAluno.Email = Console.ReadLine();

                MeusDados.InserirAluno(MeuAluno);

                Console.WriteLine("\nInserir outro Registro ? (ESC cancela...)");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public void Listar()
        {
            ArrayList Lista;
            Console.Clear();

            Console.WriteLine("Listagem de Alunos Cadastrados");
            Console.WriteLine("==============================\n");
            Lista = MeusDados.ListarAlunos();

            foreach (Aluno x in Lista)
            {
                Console.WriteLine("Nome do Aluno: {0} ({1})", x.Nome,x.Codigo);
                Console.WriteLine("Telefone.....: {0} ",x.Telefone);
                Console.WriteLine("Mail.........: {0} ",x.Mail);
            }
            Console.ReadKey();
        }
        public void Pesquisar()
        {
            Aluno MeuAluno;
            string CodPesq;

            Console.Clear();
            Console.WriteLine("Pesquisa no Cadastro de Alunos");
            Console.WriteLine("==============================\n");
            Console.Write("Código do Auno: ");
            CodPesq = Console.ReadLine().ToUpper();

            MeuAluno = MeusDados.PesquisarAluno(CodPesq);
            Console.WriteLine("==============================\n ");
            if (MeuAluno == null)
            {
                Console.WriteLine("Este aluno não existe.");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Nome do Aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Codigo);
                Console.WriteLine("Telefone.....: {0} ", MeuAluno.Telefone);
                Console.WriteLine("Mail.........: {0} ", MeuAluno.Email);
                Console.ReadKey();
            }
        }
        public void Excluir()
        {
            Aluno MeuAluno;
            string CodPesq;

            Console.Clear();
            Console.WriteLine("Exclusão de Aluno do Cadastro");
            Console.WriteLine("==============================\n");
            Console.Write("Código do Auno: ");
            CodPesq = Console.ReadLine().ToUpper();

            MeuAluno = MeusDados.PesquisarAluno(CodPesq);
            Console.WriteLine("==============================\n ");
            if (MeuAluno == null)
            {
                Console.WriteLine("Este aluno não existe.");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Nome do Aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Codigo);
                Console.WriteLine("Telefone.....: {0} ", MeuAluno.Telefone);
                Console.WriteLine("Mail.........: {0} ", MeuAluno.Email);

                MeusDados.ExcluirAluno(MeuAluno);

                Console.WriteLine("\nAluno excluído do Cadastro!");
                Thread.Sleep(2000);
            }
        }
        public void Alterar()
        {
            Aluno MeuAluno;
            Aluno MeuAlunoAlterado;
            string CodPesq;

            Console.Clear();
            Console.WriteLine("Alteração de Dados de Aluno no Cadastro");
            Console.WriteLine("==============================\n");
            Console.Write("Código do Auno: ");
            CodPesq = Console.ReadLine().ToUpper();

            MeuAluno = MeusDados.PesquisarAluno(CodPesq);
            MeuAlunoAlterado = new Aluno();

            Console.WriteLine("==============================\n ");
            if (MeuAluno == null)
            {
                Console.WriteLine("Este aluno não existe.");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Nome do Aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Codigo);
                Console.WriteLine("Telefone.....: {0} ", MeuAluno.Telefone);
                Console.WriteLine("Mail.........: {0} ", MeuAluno.Email);

                Console.WriteLine("\nDados de Atualização: \n");

                MeuAlunoAlterado.Codigo = MeuAluno.Codigo;
                Console.Write("Nome do Aluno: ");
                MeuAlunoAlterado.Nome = Console.ReadLine();
                Console.Write("Telefone.....: ");
                MeuAlunoAlterado.Telefone = Console.ReadLine();
                Console.Write("Mail.........: ");
                MeuAlunoAlterado.Email = Console.ReadLine();

                MeusDados.AlterarAluno(MeuAluno, MeuAlunoAlterado);

                Console.WriteLine("\nDados atualizados");
            }
        }
    }
}
