using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_linq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetorA = { 98, 45, 67, 23, 18, 90, 58, 30, 26, 72 };
            int[] vetorB = { 35, 48, 97, 65, 17, 49, 93, 50, 32, 71 };
            string[] vetorC = { "FiAT", "CheVROleT", "ToYOTa", "MitSUBshI", "VOlkSwAGEn" };
            string[] vetorD = { "Banana", "Abacate", "Melancia", "Amora", "Caju", "Abacaxi", "Maça" };

            var consulta = from Valor in vetorA
                           where Valor >= 50
                           orderby Valor
                           select Valor;

            foreach (int x in consulta)
                Console.Write("{0}\t",x);

            int consultaB = (from Valor in vetorA
                             where Valor >= 50
                             orderby Valor
                             select Valor).Count();
            Console.Write("Quantidade de Ocorrencias: {0}", consultaB);

            var comparar = from Valor1 in vetorA
                           from Valor2 in vetorB
                           where Valor1 <= Valor2
                           select new { Valor1, Valor2 };

            foreach (var x in comparar)
                Console.WriteLine("{0} < {1}", x.Valor1, x.Valor2);

            var palavra = from valor in vetorC
                          select new
                          {
                              maiusculas = valor.ToUpper(),
                              minusculas = valor.ToLower()
                          };

            foreach (var x in palavra)
                Console.WriteLine("{0,10} | {1}", x.maiusculas, x.minusculas);

            var fruta = from nome in vetorD
                        orderby nome
                        group nome by nome[0];

            foreach (var grupoFruta in fruta)
            {
                Console.WriteLine("Frutas com letra {0}: ", grupoFruta.Key);
                foreach (var x in grupoFruta)
                {
                    Console.WriteLine("\t => {0}",x);
                }
            }

            Console.ReadKey();
        }
    }
}
