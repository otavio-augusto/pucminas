using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_funcionario
{
    class Funcionario
    {
        private String nome;
        private double salario;
        private double novoSalario;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public double NovoSalario
        {
            get { return novoSalario; }
            set { novoSalario = value; }
        }



    }
}
