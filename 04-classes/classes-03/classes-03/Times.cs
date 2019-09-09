using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_03
{
    class Times
    {
        private String nome;
        private String presidente;
        private String tecnico;
        private DateTime fundacao;
        private String cidade;
        private String uf;

        public string Nome { get => nome; set => nome = value; }
        public string Presidente { get => presidente; set => presidente = value; }
        public string Tecnico { get => tecnico; set => tecnico = value; }
        public DateTime Fundacao { get => fundacao; set => fundacao = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public Times cadastrar()
        {
            Console.Write("Nome do Time...: "); this.Nome = Console.ReadLine();
            Console.Write("Presidente.....: "); this.Nome = Console.ReadLine();
            Console.Write("Tecnico........: "); this.Nome = Console.ReadLine();
            Fundacao = new DateTime();
            Console.Write("Fundação - Dia.:"); Fundacao.AddDays(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Fundação - Mes.:"); Fundacao.AddMonths(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Fundação - Ano.:"); Fundacao.AddYears(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Cidade.........: "); this.Nome = Console.ReadLine();
            Console.Write("Estado.........: "); this.Nome = Console.ReadLine();
            return this;
        }

        public void listar()
        {
            Console.Write("Nome do Time...: {0}\n", this.Nome); 
            Console.Write("Presidente.....: {0}\n", this.Presidente); 
            Console.Write("Tecnico........: {0}\n", this.Tecnico); 
            Console.Write("Fundação - Dia.: {0}\n", this.Fundacao.Day); 
            Console.Write("Fundação - Mes.: {0}\n", this.Fundacao.Month); 
            Console.Write("Fundação - Ano.: {0}\n", this.Fundacao.Year); 
            Console.Write("Cidade.........: {0}\n", this.Cidade); 
            Console.Write("Estado.........: {0}\n", this.Uf); 
        }
    }
}
