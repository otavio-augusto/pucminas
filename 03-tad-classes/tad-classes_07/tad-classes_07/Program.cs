using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_07
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayCategoria = new ArrayList();
            Categoria categoria = new Categoria();
            do
            {
                Console.Clear();
                arrayCategoria.Add(categoria.cadastrar());
                Console.Write("Pressione ESC para sair ou outra tecla para cadastrar outra categoria.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            ArrayList arrayProduto = new ArrayList();
            Produto produto = new Produto();
            do
            {
                Console.Clear();
                arrayProduto.Add(produto.cadastrar());
                Console.Write("Pressione ESC para sair ou outra tecla para cadastrar outro produto.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            produto.listar(arrayProduto, arrayCategoria);
            Console.ReadKey();
        }
    }
}
