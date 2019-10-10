using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_abstracao02
{
    class AlternaCaixa : Operacao
    {
        public override string passarTexto(string texto)
        {
            String resultado = "";
            int tamanho = texto.Length;
            for (int i = 0; i < tamanho; i++)
            {
                if(texto[i].ToString().ToUpper() == texto[i].ToString())
                    resultado += texto[i].ToString().ToLower();
                else
                    resultado += texto[i].ToString().ToUpper();
            }
            return resultado;
        }
    }
}
