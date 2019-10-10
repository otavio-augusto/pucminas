using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_enum
{
    class Temporario : Professor
    {
        private String dataInicio;
        private String dataFim;

        public String DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }
        public String DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }
        public override void listar()
        {
            Console.Write("Nome.......: {0}", this.Nome);
            Console.Write("Nascimento.: {0}", this.Nascimento);
            Console.Write("Inicio.....: {0}", this.DataInicio);
            Console.Write("Fim........: {0}", this.DataFim);
        }
    }
}
