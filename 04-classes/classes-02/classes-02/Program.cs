using classes_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrizes matriz1 = new Matrizes(4,4,true);
            Matrizes matriz2 = new Matrizes(4,4,true);
            matriz1.listar();
            matriz2.listar();
            OperaMatrizes operaMatrizes = new OperaMatrizes();
            Matrizes resultado = operaMatrizes.multiplicar(matriz1, matriz2);
            resultado.listar();
            Console.ReadKey();
        }
    }
}
