using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_ex03
{
    class Paciente
    {
        private String nome;
        private String telefone;
        private String nascimento;
        private String email;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Email { get => email; set => email = value; }

        public Paciente cadastrar()
        {
            Console.Write("Nome.......: "); Nome = Console.ReadLine();
            Console.Write("Telefone...: "); Telefone = Console.ReadLine();
            Console.Write("Nascimento.: "); Nascimento = Console.ReadLine();
            Console.Write("Email......: "); Email = Console.ReadLine();
            return this;
        }

        public void Listar(ArrayList dados)
        {
            foreach (Paciente paciente in dados)
            {
                Console.WriteLine("Nome.......: {0}", Nome);
                Console.WriteLine("Telefone...: {0}", Telefone);
                Console.WriteLine("Nascimento.: {0}", Nascimento);
                Console.WriteLine("Email......: {0}", Email);
            }
        }
    }
}
