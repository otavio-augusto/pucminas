using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_01
{
    struct Data
    {
        private int dia;
        private int mes;
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
    }
    class Funcionario
    {
        private string nome;
        private Data aniversario;
        private double salario;
        private string area;

        public string Nome { get => nome; set => nome = value; }
        public Data Aniversario { get => aniversario; set => aniversario = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Area { get => area; set => area = value; }

        public Funcionario cadastrar()
        {
            Data data = new Data();
            Console.Write("Nome..............: "); Nome = Console.ReadLine();
            Console.Write("Salario...........: "); Salario = float.Parse(Console.ReadLine());
            Console.Write("Area..............:\n1 - Produção\n2 - Estoque\n: ");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Area = "Produção";
                    break;
                case '2': 
                    Area = "Estoque";
                    break;
            }
            Console.Write("\nAniversario - Dia.: "); data.Dia = int.Parse(Console.ReadLine());
            Console.Write("Aniversario - Mes.: "); data.Mes = int.Parse(Console.ReadLine());
            this.aniversario = data;
            return this;
        }

        public void listar()
        {
            Console.Write("\nNome..............: {0}", Nome);
            Console.Write("\nSalario...........: {0}", Salario);
            Console.Write("\nArea..............: {0}", Area);
            Console.Write("\nAniversario - Dia.: {0}", aniversario.Dia);
            Console.Write("\nAniversario - Mes.: {0}\n", aniversario.Mes);
        }
    }
}
