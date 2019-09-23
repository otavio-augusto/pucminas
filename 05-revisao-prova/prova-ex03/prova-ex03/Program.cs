using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dados = new ArrayList();
            Paciente paciente = new Paciente();

            dados.Add(paciente.cadastrar());
            paciente.Listar(dados);

            Console.ReadKey();
        }
    }
}
