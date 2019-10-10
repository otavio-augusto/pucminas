using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Contratado contratado = new Contratado();
            contratado.Nome = "Adalberto";
            contratado.Disciplina = "ATP";
            contratado.Nascimento = "01/01/1991";
            contratado.Admissao = "01/01/2001";
            contratado.listar();
            contratado.mostrarNascimento();

            Temporario temporario = new Temporario();
            temporario.Nome = "Bdalberto";
            temporario.Disciplina = "POO";
            temporario.Nascimento = "02/02/1992";
            temporario.DataInicio = "02/02/2002";
            temporario.DataFim = "02/04/2002";
            temporario.listar();
            temporario.mostrarNascimento();
        }
    }
}
