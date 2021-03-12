using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditorCG
{
    class Transformacoes
    {


        public String nome { get; set; }
        public String posicoes { get; set; }


        public Transformacoes(String nome, String qtdPontos)
        {
            this.nome = nome;
            this.posicoes = qtdPontos;
        }


    }
}
