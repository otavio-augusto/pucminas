using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_07
{
    class Categoria
    {
        private int codigo;
        private String descricao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public Categoria cadastrar()
        {
            Console.Write("Codigo da Categoria....: "); this.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Descrição da Categoria.: "); this.Descricao = Console.ReadLine();
            return this;
        }
    }

    
}
