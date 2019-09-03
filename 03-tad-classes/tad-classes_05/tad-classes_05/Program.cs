using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculo = new Veiculo[2];
            for (int i = 0; i < veiculo.Length; i++)
            {
                Console.Write("Escolha o tipo de veiculo: \n1- Passeio\n2- Carga\n");
                char op1 = Convert.ToChar(Console.ReadLine());
                switch (op1)
                {
                    case '1':
                        veiculo[i] = cadastrarPasseio();
                        break;
                    case '2':
                        veiculo[i] = cadastrarCarga();
                        break;
                    default:
                        Console.WriteLine("Opção Invalida, tente novamente.");
                        i--;
                        break;
                }

            }

            char op = '1';
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu de Controle:\n1 - Listar a frota.\n2 - Consultar Valor.\n 0 - Sair");
                op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '1':
                        for (int i = 0; i < veiculo.Length; i++)
                        {
                            if (veiculo[i] is VeiculoPasseio)
                            {
                                VeiculoPasseio veiculoPasseio = (VeiculoPasseio)veiculo[i];
                                Console.WriteLine(veiculoPasseio.resumo());
                            }
                            else if (veiculo[i] is VeiculoCarga)
                            {
                                VeiculoCarga veiculoCarga = (VeiculoCarga)veiculo[i];
                                Console.WriteLine(veiculoCarga.resumo());
                            }
                        }
                        
                        break;
                    case '2':
                        
                        Console.Write("Placa: ");
                        Console.WriteLine("Valor de Locação: {0}",consultarValor(Console.ReadLine(), veiculo));
                        break;
                    case '0':
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }


        }
        public static float consultarValor(String placa, Veiculo[] veiculo)
        {
            float valor = 0;
            for (int i = 0; i < veiculo.Length; i++)
            {
                if (veiculo[i] is VeiculoPasseio)
                {
                    VeiculoPasseio veiculoPasseio = (VeiculoPasseio)veiculo[i];
                    valor = veiculoPasseio.Valor;
                    break;
                } else if(veiculo[i] is VeiculoCarga)
                {
                    VeiculoCarga veiculoCarga = (VeiculoCarga)veiculo[i];
                    valor = veiculoCarga.Valor;
                    break;
                }
            }
            return valor;
        }

        public static VeiculoPasseio cadastrarPasseio()
        {
            VeiculoPasseio veiculoPasseio = new VeiculoPasseio();
            Console.Write("Placa................: "); veiculoPasseio.Placa = Console.ReadLine();
            Console.Write("Modelo...............: "); veiculoPasseio.Modelo = Console.ReadLine();
            Console.Write("Ano..................: "); veiculoPasseio.Ano = Console.ReadLine();
            Console.Write("Categoria............: "); veiculoPasseio.Categoria = Console.ReadLine();
            Console.Write("Valor do KM..........: "); veiculoPasseio.KmValor = Convert.ToInt32(Console.ReadLine());
            Console.Write("KM Inicial...........: "); veiculoPasseio.KmInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("KM Final.............: "); veiculoPasseio.KmFinal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade de Portas.: "); veiculoPasseio.Portas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tipo de Combustivel..: "); veiculoPasseio.Combustivel = Console.ReadLine();
            Console.Write("Possui Ar Condicionado:\n1- Sim\n2- Não :");
            char op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '1':
                    veiculoPasseio.Ar = true;
                    break;
                case '2':
                    veiculoPasseio.Ar = false;
                    break;
            }
            Console.WriteLine("Cadastro Concluido!\n");
            return veiculoPasseio;
        }

        public static VeiculoCarga cadastrarCarga()
        {
            VeiculoCarga veiculoCarga = new VeiculoCarga();
            Console.Write("Placa.......: "); veiculoCarga.Placa = Console.ReadLine();
            Console.Write("Modelo......: "); veiculoCarga.Modelo = Console.ReadLine();
            Console.Write("Ano.........: "); veiculoCarga.Ano = Console.ReadLine();
            Console.Write("Categoria...: "); veiculoCarga.Categoria = Console.ReadLine();
            Console.Write("Valor do KM.: "); veiculoCarga.KmValor = Convert.ToInt32(Console.ReadLine());
            Console.Write("KM Inicial..: "); veiculoCarga.KmInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("KM Final....: "); veiculoCarga.KmFinal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Capacidade..: "); veiculoCarga.Capacidade = Convert.ToInt32(Console.ReadLine());
            return veiculoCarga;
        }
    }
}
