using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditorCG
{
    public class Aresta
    {
        public Point2D p1;      //public int p1;
        public Point2D p2;      //public int p2;

        public Aresta() {

        }

        public Aresta(Point2D p1, Point2D p2) {

            this.p1 = p1;
            this.p2 = p2;
        }

        public override String ToString() {
            return "Aresta{" + "p1=" + p1 + ", p2=" + p2 + '}';
        }
    }
}
