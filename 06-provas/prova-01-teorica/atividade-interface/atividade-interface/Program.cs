using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            DateTime total, reducao;
            String data, hora;

            Console.Write("Data 1: "); data = Console.ReadLine();
            Console.Write("Hora 1: "); hora = Console.ReadLine();
            total = agenda.inicializar(data, hora);

            Console.Write("Data 2: "); data = Console.ReadLine();
            Console.Write("Hora 2: "); hora = Console.ReadLine();
            reducao = agenda.inicializar(data, hora);

            Console.WriteLine("\nDiferença entre Datas: {0} dias e {1} horas.",
                agenda.subtrairDatas(total, reducao),
                agenda.subtrairHora(total, reducao));

            Console.ReadKey();
        }
    }
}
