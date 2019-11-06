using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_linq_03
{
    //public delegate void meuDelegate(ArrayList lista);
    //public delegate int Calculo(int x, int y);
    //public delegate double Delta(double a, double b, double c);

    class Program
    {
        static void Main(string[] args)
        {
            #region Carros
            /*
            ArrayList carros = new ArrayList();
            carros.Add("Fiat Stilo");
            carros.Add("Toyota Corola");
            carros.Add("Volkswagen Golf");
            carros.Add("Chevrolet S10");
            carros.Add("Mitsubishi Lancer");
            carros.Add("Ford Ka");
            meuDelegate mostrar = new meuDelegate(ABC);
            mostrar(carros);
            */
            #endregion
            #region Calculo
            /*
            Calculo calculo = new Calculo(soma);
            Console.WriteLine("Resultado: {0}", calculo(3, 7));
            Console.ReadKey();
            */
            #endregion
            #region Delta
            /*
            Delta delta = new Delta((double a, double b, double c)=>b*b-4*a*c);
            Console.WriteLine("Delta = {0:F2}",delta(2,3,-4));
            Console.ReadKey();
            */
            #endregion
            #region Lambda
            /*
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Numero de Pares: {0}", vetor.Count(n => n % 2 == 0));
            Console.ReadKey();
            var maior5 = vetor.Where(x => x > 5);
            foreach (int n in maior5)
                Console.Write("{0,5}",n);
            Console.ReadKey();
            */
            #endregion
            Console.WriteLine("Delta: {0:F2}", Delta(1,3,-4));
            Console.WriteLine("Fatorial: {0}", Fatorial(5));
            Console.ReadKey();
        }

        #region Função Soma
        static int soma(int a, int b)
        {
            return a + b;
        }
        #endregion
        #region Função ABC
        static void ABC (ArrayList lista)
        {
            foreach (var x in lista)
            {
                Console.WriteLine("{0}",x);
            }
            Console.ReadKey();
        }
        #endregion
        static Func<int, int, int, int> Delta = (a, b, c) => b * b - 4 * a * c;
        static Func<int, int> Fatorial = x => (x == 0) ? 1 : x * Fatorial(x - 1);
    }
}
