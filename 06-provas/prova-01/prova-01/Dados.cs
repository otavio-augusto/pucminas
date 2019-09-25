using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Dados
    {
        private ArrayList arrayList;
        private int tamanho;

        public int Tamanho { get => tamanho; set => tamanho = value; }

        public Funcionario this[int i]
        {
            get { return (Funcionario) arrayList[i]; }
            set { arrayList.Insert(i, value); }
        }
        public Dados(int tamanho)
        {
            arrayList = new ArrayList();
            this.tamanho = tamanho;
        }

        public void relatorio()
        {
            double mediaEstoque = media(this, "Estoque");
            double mediaProducao = media(this, "Producao");

            Console.WriteLine("Funcionarios de Produção Acima da Media: ");
            for (int i = 0; i < this.Tamanho; i++)
            {
                if (this[i].Area == "Produção" && this[i].Salario > mediaEstoque) this[i].listar();
            }

            Console.WriteLine("Funcionarios de Estoque Acima da Media: ");
            for (int i = 0; i < this.Tamanho; i++)
            {
                if (this[i].Area == "Estoque" && this[i].Salario > mediaProducao) this[i].listar();
            }

        }
        public double media(Dados dados, string area)
        {
            double resultado = 0;
            for (int i = 0; i < dados.Tamanho; i++)
            {
                if (dados[i].Area == area) resultado += dados[i].Salario;
            }
            return resultado;
        }
    }
}
