using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_05
{
    class Veiculo
    {
        private String placa;
        private String modelo;
        private String ano;
        private String categoria;
        private int kmValor;
        private int kmInicial;
        private int kmFinal;

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int KmValor { get => kmValor; set => kmValor = value; }
        public int KmInicial { get => kmInicial; set => kmInicial = value; }
        public int KmFinal { get => kmFinal; set => kmFinal = value; }
    }
    class VeiculoPasseio : Veiculo
    {
        private bool ar;
        private String combustivel;
        private int portas;
        private float valor;

        public bool Ar { get => ar; set => ar = value; }
        public string Combustivel { get => combustivel; set => combustivel = value; }
        public int Portas { get => portas; set => portas = value; }
        public float Valor { get => valor; set => valor = value; }

        public String resumo()
        {
            String resumo =
                "Placa................: " + base.Placa + " \n" +
                "Modelo...............: " + base.Modelo + " \n" +
                "Ano..................: " + base.Ano + " \n" +
                "Categoria............: " + base.Categoria + " \n" +
                "Valor do KM..........: " + base.KmValor + " \n" +
                "KM Inicial...........: " + base.KmInicial + " \n" +
                "KM Final.............: " + base.KmFinal + " \n" +
                "Combustivel..........: " + Combustivel + " \n" +
                "Ar Condicionado......: " + Ar + " \n" +
                "Quantidade de Portas.: " + Portas + " \n" +
                "Valor................: " + Valor + "\n";
            return resumo;
        }

    }

    class VeiculoCarga : Veiculo
    {
        private float capacidade;
        public float Valor { get => ((KmFinal - KmInicial) * KmValor) + ((KmFinal - KmInicial) * KmValor) * 0.1f; }
        public float Capacidade { get => capacidade; set => capacidade = value; }

        public String resumo()
        {
            String resumo =
                "Placa................: " + base.Placa + " \n" +
                "Modelo...............: " + base.Modelo + " \n" +
                "Ano..................: " + base.Ano + " \n" +
                "Categoria............: " + base.Categoria + " \n" +
                "Valor do KM..........: " + base.KmValor + " \n" +
                "KM Inicial...........: " + base.KmInicial + " \n" +
                "KM Final.............: " + base.KmFinal + " \n" +
                "Capacidade...........: " + Capacidade + " \n" +
                "Valor................: " + Valor + " \n";
            return resumo;
        }
    }
}
