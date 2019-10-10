using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao02
{
    class RetiraVogais : Operacao
    {
        public override string passarTexto(string texto)
        {
            String resultado = "";
            resultado = texto.Replace("A", "");
            resultado = resultado.Replace("a", "");
            resultado = resultado.Replace("E", "");
            resultado = resultado.Replace("e", "");
            resultado = resultado.Replace("I", "");
            resultado = resultado.Replace("i", "");
            resultado = resultado.Replace("O", "");
            resultado = resultado.Replace("o", "");
            resultado = resultado.Replace("U", "");
            resultado = resultado.Replace("u", "");
            return resultado;
        }
    }
}
