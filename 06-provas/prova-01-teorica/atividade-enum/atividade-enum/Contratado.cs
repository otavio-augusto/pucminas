using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_enum
{
    class Contratado : Professor
    {
        private String admissao;

        public String Admissao
        {
            get { return admissao; }
            set { admissao = value; }
        }

        public override void listar()
        {
            Console.Write("Nome.......: {0}", this.Nome);
            Console.Write("Disciplina.: {0}", this.Disciplina);
            Console.Write("Nascimento.: {0}", this.Nascimento);
            Console.Write("Admitido...: {0}", this.Admissao);
        }

        public override void mostrarNascimento()
        {
            base.mostrarNascimento();
            int mes = Convert.ToInt32(this.Nascimento.Substring(3,2));
            mesesEnum meses;
            meses = mesesEnum.Janeiro;
            meses += mes - 1;
            Console.Write("Mes.......: {0}", this.Nascimento);
        }
    }
}
