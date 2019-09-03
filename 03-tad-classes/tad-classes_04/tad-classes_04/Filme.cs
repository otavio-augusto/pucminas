using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_04
{

    class Filme
    {
        private String nome;
        private String duracao;
        private String diretor;
        private String categoria;

        public string Nome { get => nome; set => nome = value; }
        public string Duracao { get => duracao; set => duracao = value; }
        public string Diretor { get => diretor; set => diretor = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        //TODO adicionar dados relevantes;

        public Boolean isMesmaCategoria(String categoria)
        {
            if (this.Categoria == categoria) return true;
            else return false;
        }
    }
}
