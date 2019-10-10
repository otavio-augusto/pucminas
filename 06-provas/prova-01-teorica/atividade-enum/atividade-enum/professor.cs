using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_enum
{
    public abstract class Professor
    {
        public enum mesesEnum { Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro }

        private String nome;
        private String disciplina;
        private String nascimento;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }
        public String Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        public abstract void listar();
        public virtual void mostrarNascimento()
        {
            Console.WriteLine("Nascimento: {0}", Nascimento.Substring(0,2));
        }
    }
}
