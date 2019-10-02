using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MVC
{
    class Dados
    {
        private ArrayList Cadastro;
        public Dados()
        {
            Cadastro = new ArrayList();
        }
        public void InserirAluno(Aluno x)
        {
            Cadastro.Add(x);
        }
        public ArrayList ListarAlunos()
        {
            return Cadastro;
        }
        public Aluno PesquisarAluno(string Cod)
        {
            foreach (Aluno x in Cadastro)
            {
                if(x.Codigo == Cod)
                {
                    return x;
                }
            }
            return null;

        }
        public void ExcluirAluno(Aluno x)
        {
            Cadastro.Remove(x);
        }
        public void AlterarAluno(Aluno x, Aluno y)
        {
            int Posicao;

            Posicao = Cadastro.IndexOf(x);

            Cadastro.Remove(x);
            Cadastro.Insert(Posicao, y);
        }
    }
}
