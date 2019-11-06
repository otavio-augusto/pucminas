using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_linq_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Voto[] vetorVotos = new Voto[8];

            #region Votos Declarados
            Voto voto = new Voto();
            voto.numero = 123;
            voto.eleitor = 938474;
            voto.uf = "MG";
            vetorVotos[0] = voto;

            voto = new Voto();
            voto.numero = 456;
            voto.eleitor = 495009;
            voto.uf = "ES";
            vetorVotos[1] = voto;

            voto = new Voto();
            voto.numero = 789;
            voto.eleitor = 464604;
            voto.uf = "ES";
            vetorVotos[2] = voto;

            voto = new Voto();
            voto.numero = 456;
            voto.eleitor = 495009;
            voto.uf = "MG";
            vetorVotos[3] = voto;

            voto = new Voto();
            voto.numero = 123;
            voto.eleitor = 126790;
            voto.uf = "MG";
            vetorVotos[4] = voto;

            voto = new Voto();
            voto.numero = 456;
            voto.eleitor = 345678;
            voto.uf = "ES";
            vetorVotos[5] = voto;

            voto = new Voto();
            voto.numero = 123;
            voto.eleitor = 899887;
            voto.uf = "ES";
            vetorVotos[6] = voto;

            voto = new Voto();
            voto.numero = 123;
            voto.eleitor = 126790;
            voto.uf = "MG";
            vetorVotos[7] = voto;
            #endregion

            #region Todos os Votos
            foreach (Voto x in vetorVotos)
                Console.Write(
                    "Numero..: {0}\n" +
                    "Eleitor.: {1}\n" +
                    "Estado..: {2}\n\n", x.numero, x.eleitor, x.uf);

            var votosMG = from V in vetorVotos
                          where V.uf == "MG"
                          select V;

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Votos Em MG
            Console.WriteLine("Votos no estado de Minas Gerais: ");

            foreach (Voto x in votosMG)
                Console.Write(
                    "Numero..: {0}\n" +
                    "Eleitor.: {1}\n\n", x.numero, x.eleitor);

            var votosQuebra = from V in vetorVotos
                              orderby V.uf
                              group V by V.uf;

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Votos por Estado
            Console.WriteLine("Votos por Estado: ");

            foreach (var x in votosQuebra)
            {
                Console.WriteLine("" +
                    "Origem dos Votos.: {0}\n" +
                    "Quantidade.......: {1}", x.Key, x.Count());
                foreach (var y in x)
                {
                    Console.Write(
                        "Numero..: {0}\n" +
                        "Eleitor.: {1}\n\n", y.numero, y.eleitor);
                }
            }

            var votoCandidato = from V in vetorVotos
                                orderby V.numero
                                group V by V.numero;

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Votos por Candidato
            Console.WriteLine("Votos por Candidato: ");
            foreach (var x in votoCandidato)
            {
                Console.WriteLine("" +
                    "Candidato..: {0}\n" +
                    "Quantidade.: {1}", x.Key, x.Count());
                foreach (var y in x)
                {
                    Console.Write(
                        "\tNumero..: {0}\n" +
                        "\tEleitor.: {1}\n\n", y.numero, y.eleitor);
                }
            }

            Console.ReadKey();
            Console.Clear();
            #endregion


        }
    }
}
