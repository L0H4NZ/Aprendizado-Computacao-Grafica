using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditorCG
{
    public class Point2D
    {
        private float[,] valor = new float[1,3];

        public Point2D() {
            this.valor[0,0] = 0f;
            this.valor[0,1] = 0f;
            this.valor[0,2] = 1f;
        }

        public Point2D(float x, float y) {
            this.valor[0,0] = x;
            this.valor[0,1] = y;
            this.valor[0,2] = 1f;
        }

        public Point2D(float x, float y, float w) {
            this.valor[0,0] = x;
            this.valor[0,1] = y;
            this.valor[0,2] = w;
        }

        public float getX() {
            return this.valor[0,0];
        }

        public void setX(float x) {
            this.valor[0,0] = x;
        }

        public float getY() {
            return this.valor[0,1];
        }

        public void setY(float y) {
            this.valor[0,1] = y;
        }

        public float getW() {
            return this.valor[0,2];
        }

        public void setW(float w) {
            this.valor[0,2] = w;
        }

        public float[,] getValor() {
            return valor;
        }

        public void setValor(float[,] valor) {
            this.valor = valor;
        }
    }
}
