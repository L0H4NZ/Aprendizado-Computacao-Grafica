using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditorCG
{
    public class Transformadas
    {

        public static float[,] Tr(float ang /*em graus*/){
        ang = (float) (ang * Math.PI / 180.0);
        float cos = (float) Math.Cos(ang);
        float sin = (float) Math.Sin(ang);
        float[,] C = {
            { cos, sin, 0},
            {-sin, cos, 0},
            {   0,   0, 1}
        };
        return C;
    }

        public static float[,] Tt(float dx, float dy /*em graus*/){
        float[,] C = {
            {  1,  0, 0},
            {  0,  1, 0},
            { dx, dy, 1}
        };
        return C;
    }

        public static float[,] Ts(float sx, float sy /*em graus*/){
        float[,] C = {
            { sx, 0,  0},
            {  0, sy, 0},
            {  0,  0, 1}
        };
        return C;
    }

        public static Geometria aplica(Geometria geometria, float[,] T){
        foreach (Point2D ponto in geometria.getPontos()) {
            float[,] C = CgUtils.mult(ponto.getValor(), T);
            ponto.setValor(C);
        }
        return geometria;
    }
    }
}
