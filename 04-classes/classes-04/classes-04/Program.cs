using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();
            Varzea varzea = new Varzea();
            Profissional profissional = new Profissional();
            do
            {
                Console.Clear();
                Console.Write("Menu:\n1 - Cadastrar Time\n2 - Listar Times: ");
                switch (Console.ReadLine()[0])
                {
                    case '1':
                        Console.Write("Tipo de Time:\n 1 - Time Profissional\n 2 - Time de Varzea: ");
                        switch (Console.ReadLine()[0])
                        {
                            case '1':
                                dados[dados.Index] = profissional.Cadastrar();
                                break;
                            case '2':
                                dados[dados.Index] = varzea.Cadastrar();
                                break;
                        }
                        break;
                    case '2':
                        foreach (Times time in dados.Dado)
                        {
                            if(time is Profissional)
                            {
                                Profissional x = (Profissional) time;
                                x.Listar();
                            } else
                            {
                                Varzea x = (Varzea)time;
                                x.Listar();
                            }
                        }
                        break;
                }
                Console.WriteLine("Continuar? (ESC para sair)");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
