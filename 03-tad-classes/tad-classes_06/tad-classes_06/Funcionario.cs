using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_06
{
    class Funcionario
    {
        private String nome;
        private String endereco;
        private String telefone;
        private String email;
        private String admissao;
        private String nascimento;
        private String nomePai;
        private String nomeMae;
        private String indentidade;
        private String cpf;
        private String carteiraTrabalhador;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Admissao { get => admissao; set => admissao = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string NomePai { get => nomePai; set => nomePai = value; }
        public string NomeMae { get => nomeMae; set => nomeMae = value; }
        public string Indentidade { get => indentidade; set => indentidade = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string CarteiraTrabalhador { get => carteiraTrabalhador; set => carteiraTrabalhador = value; }
    }

    class Administrador : Funcionario
    {
        private String cargo;
        private String setor;

        public string Cargo { get => cargo; set => cargo = value; }
        public string Setor { get => setor; set => setor = value; }
    }
    
    class Professor : Funcionario
    {
        private int horasAula;
        private int aulasSemanais;
        private String titulacao;

        public int HorasAula { get => horasAula; set => horasAula = value; }
        public int AulasSemanais { get => aulasSemanais; set => aulasSemanais = value; }
        public string Titulacao { get => titulacao; set => titulacao = value; }
    }
}
