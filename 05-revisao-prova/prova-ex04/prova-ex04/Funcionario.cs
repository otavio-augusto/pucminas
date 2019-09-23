using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_ex04
{
    class Funcionario
    {
        public Funcionario(String nome, String endereco, String telefone, String carteira, double salario)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Carteira = carteira;
            this.Salario = salario;
        }

        private String nome;
        private String endereco;
        private String telefone;
        private String carteira;
        private double salario;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Carteira { get => carteira; set => carteira = value; }
        public double Salario { get => salario; set => salario = value; }

        public void listar()
        {
            Console.Write(
                        "\nNome.....: {0}\n" +
                        "Endereco.: {1}\n" +
                        "Telefone.: {2}\n" +
                        "Carteira.: {3}\n" +
                        "Salario..: {4}\n", Nome, Endereco, Telefone, Carteira, Salario);
        }
    }

    class Professor : Funcionario
    {
        public Professor(string nome, string endereco, string telefone, string carteira, double salario, String especialidade) : base(nome, endereco, telefone, carteira, salario)
        {
            this.Especialidade = especialidade;
        }

        private String especialidade;

        public string Especialidade { get => especialidade; set => especialidade = value; }

        public new void listar()
        {
            base.listar();
            Console.Write("Especialidade.: {0}\n", Especialidade);
        }
    }
}
