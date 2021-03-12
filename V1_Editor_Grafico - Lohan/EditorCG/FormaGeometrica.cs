using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditorCG
{
    class FormaGeometrica
    {
        public String nome { get; set; }
        public String qtdPontos { get; set; }


        public FormaGeometrica(String nome, String qtdPontos)
        {
            this.nome = nome;
            this.qtdPontos = qtdPontos;
        }
    }
}
