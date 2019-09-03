using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_07
{
    class Produto
    {
        private String nome;
        private int codigoCategoria;
        private double preco;
        private int quantidade;

        public string Nome { get => nome; set => nome = value; }
        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public Produto cadastrar()
        {
            Console.Write("Nome do Produto.......:"); this.Nome = Console.ReadLine();
            Console.Write("Codigo da Categoria...:"); this.CodigoCategoria = Convert.ToInt32(Console.ReadLine());
            Console.Write("Preço do Produto......: "); this.Preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade do Produto,: "); this.Quantidade = Convert.ToInt32(Console.ReadLine());
            return this;

        }

        public void listar(ArrayList arrayProduto, ArrayList arrayCategoria)
        {
            foreach (Produto produto in arrayProduto)
            {
                Console.Write("\nNome......: {0}", produto.Nome);
                Console.Write("\nDescrição.: {0}", produto.acharCategoria(produto.CodigoCategoria, arrayCategoria));
                Console.Write("\nValor.....: {0}", produto.Preco);
                Console.Write("\nEstoque...: {0}\n", produto.Quantidade);
            }
        }

        public String acharCategoria(int codigo, ArrayList arrayCategoria)
        {
            String x = "";
            foreach (Categoria categoria in arrayCategoria)
            {
                if (categoria.Codigo == codigo) x = categoria.Descricao;
                break;
            }
            return x;
        }
    }
}
