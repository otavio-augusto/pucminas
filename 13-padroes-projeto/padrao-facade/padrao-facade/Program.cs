using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padrao_facade
{
    class Candidato
    {
        public string nome { get; set; }
        public double salario { get; set; }
    }

    class Contratacao //FACADE
    {
        private ExameMedico exameMedico = new ExameMedico();
        private ExamePsico examePsico = new ExamePsico();
        private ProvaPratica provaPratica = new ProvaPratica();
        private FaixaSalarial faixaSalarial = new FaixaSalarial();

        public bool podeContratar(Candidato candidato)
        {
            Console.Clear();
            Console.WriteLine("Contratação de {0}", candidato.nome);

            bool autorizado = true;
            if (!exameMedico.possuiCondicoes())
                autorizado = false;
            if (!examePsico.possuiCondicoes())
                autorizado = false;
            if (!provaPratica.passou())
                autorizado = false;
            if (!faixaSalarial.dentroFaixa(candidato.salario))
                autorizado = false;
            return autorizado;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Candidato candidato = new Candidato();
            candidato.nome = "Adalberto";
            candidato.salario = 1000f;
            if(new Contratacao().podeContratar(candidato))
                Console.WriteLine("Contratação Aprovada.");
            else
                Console.WriteLine("Contratação Não Aprovada.");
            Console.ReadKey();
        }
    }

    class ExameMedico
    {
        public bool possuiCondicoes()
        {
            //Avaliação
            return true;
        }
    }

    class ExamePsico
    {
        public bool possuiCondicoes()
        {
            //Avaliação
            return true;
        }
    }

    class ProvaPratica
    {
        public bool passou()
        {
            //Avaliação
            return true;
        }
    }

    class FaixaSalarial
    {
        public bool dentroFaixa(double salario)
        {
            if (salario < 5000f)
                return true;
            else
                return false;
        }
    }
}
