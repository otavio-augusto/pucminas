using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Aluno
    {
        private String codigo;
        private String nome;
        private String telefone;
        private String email;


        public string Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        public Aluno()
        {
            Codigo = Guid.NewGuid().ToString().Substring(9,4).ToUpper();
        }

    }
}
