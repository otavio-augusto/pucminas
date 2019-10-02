using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MVC
{
    static class Menu
    {
        public static void MostraMenu(Operações MinhaOperação)
        {
            int Op;
            do
            {
                Console.Clear();

                Console.WriteLine("Sistema de Cadastro de Alunos");
                Console.WriteLine("==============================\n");

                Console.WriteLine("[1] - Inserir");
                Console.WriteLine("[2] - Alterar");
                Console.WriteLine("[3] - Excluir");
                Console.WriteLine("[4] - Pesquisar");
                Console.WriteLine("[5] - Listar");
                Console.WriteLine("[6] - Ordenar");
                Console.WriteLine("[7] - Salvar Dados em Arquivo");
                Console.WriteLine("[8] - Ler Dados do Arquivo");
                Console.WriteLine("[9] - Sair");

                Console.Write("\nOpção: ");
                Op = int.Parse(Console.ReadLine());
                switch (Op)
                {
                    case 1:
                        // Inserir
                        MinhaOperação.Inserir(new Aluno());
                        break;
                    case 2:
                        // Alterar 
                        MinhaOperação.Alterar();
                        break;
                    case 3:
                        // Excluir
                        MinhaOperação.Excluir();
                        break;
                    case 4:
                        // Pesquisar
                        MinhaOperação.Pesquisar();

                        break;
                    case 5:
                        // Listar
                        MinhaOperação.Listar();
                        break;
                    case 6:
                        // Ordenar
                        
                        break;
                    case 7:
                        // SalvarXML
                        break;
                    case 8:
                        // CarregarXML
                        break;
                    case 9:
                        // Sair
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Saindo");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Saindo.");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Saindo..");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Saindo...");
                            Thread.Sleep(200);
                        }
                        break;
                    default:
                        Console.Write("Opção inválida");
                        Thread.Sleep(2000);
                        break;
                }
            } while (Op != 9);
        }
    }
}
