using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Editor3D
{
    class CoordenadasAnimacao
    {

         public CoordenadasAnimacao(String nome)
        {
            this.nome = nome;
            trX = 0;
            trY = 0;
            trZ = 0;
            ttX = 0;
            ttY = 0;
            ttZ = 0;
            tsX = 1;
            tsZ = 1;
            tsY = 1;

        }
        public String nome { get; set; }
        public float trX { get; set; }
        public float trY { get; set; }
        public float trZ { get; set; }
        public float ttX { get; set; }
        public float ttY { get; set; }
        public float ttZ { get; set; }
        public float tsX { get; set; }
        public float tsY { get; set; }
        public float tsZ { get; set; }
        
        
    }
}
