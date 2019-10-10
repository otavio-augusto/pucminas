using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_interface
{
    class Agenda : Relogio, Calendario
    {
        public DateTime inicializar(String data, String horario)
        {
            int dia, mes, ano;
            int hora, minuto;
            dia = Convert.ToInt16(data.Substring(0, 2));
            mes = Convert.ToInt16(data.Substring(3, 2));
            ano = Convert.ToInt16(data.Substring(6, 4));

            hora = Convert.ToInt16(horario.Substring(0, 2));
            minuto = Convert.ToInt16(horario.Substring(3, 2));

            return new DateTime(ano, mes, dia, hora, minuto, 0);
        }

        public string subtrairDatas(DateTime total, DateTime reducao)
        {
            TimeSpan resultado = total - reducao;
            return resultado.Days.ToString();
        }

        public string subtrairHora(DateTime total, DateTime reducao)
        {
            TimeSpan resultado = total - reducao;
            return resultado.Hours.ToString();
        }
    }
}
