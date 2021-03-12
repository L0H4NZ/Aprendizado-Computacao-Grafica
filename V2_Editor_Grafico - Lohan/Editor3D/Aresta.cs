using System.Collections.Generic;
using System;
using System.Drawing;

public class Aresta {

    public int pInicial;      //public int p1;
    public int pFinal;        //public int p2;

    public Aresta() {

    }

    public Aresta(int pInicial, int pFinal) {

        this.pInicial = pInicial;
        this.pFinal = pFinal;
    }


    public override String ToString() {
        return "Aresta{" + "p1=" + pInicial + ", p2=" + pFinal + '}';
    }

}
