using System.Collections.Generic;
using System;
using System.Drawing;


public class Transformada {

    private String id;

    private float[,] definicao;

    static Transformada build(String[] dados) {

        Transformada transformada = new Transformada();
        transformada.setId(dados[0]);
        transformada.setDefinicao(Transformada.identidade());

        for (int i = 1; i < dados.GetLength(0); i++) {

            String[] parameters = dados[i].Split(' ');

            float[,] definicaoAtual = null;

            if (parameters[0] == "tt") {

                definicaoAtual = Transformada.Tt(Convert.ToSingle(parameters[1]), Convert.ToSingle(parameters[2]), Convert.ToSingle(parameters[3]));

            } else if (parameters[0] == "trz") {

                definicaoAtual = Transformada.TrZ(Convert.ToSingle(parameters[1]));

            } else if (parameters[0] == "trx") {

                definicaoAtual = Transformada.TrX(Convert.ToSingle(parameters[1]));

            } else if (parameters[0] == "try") {

                definicaoAtual = Transformada.TrY(Convert.ToSingle(parameters[1]));

            } else if (parameters[0] == "ts") {

                definicaoAtual = Transformada.Ts(Convert.ToSingle(parameters[1]), Convert.ToSingle(parameters[2]), Convert.ToSingle(parameters[3]));
            }

            transformada.setDefinicao(CgUtils.mult(transformada.getDefinicao(), definicaoAtual));

        }
        return transformada;
    }
    
    public Transformada() {
        
        this.setDefinicao(Transformada.Tv3D(0.0f, 0.0f, 0.0f));
    }

    public static float[,] identidade() {
        float[,] saida = new float[,] {
            {1, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };
        return saida;
    }

    public static float[,] TrZ(float ang /*em graus*/) {
        ang = (float) (ang * Math.PI / 180.0);
        float cos = (float) Math.Cos(ang);
        float sin = (float) Math.Sin(ang);
        float[,] saida = new float[,] {
            { cos, sin, 0, 0},
            {-sin, cos, 0, 0},
            {   0,   0, 1, 0},
            {   0,   0, 0, 1}
        };
        return saida;
    }
    
    public static float[,] TrX(float ang /*em graus*/) {
        ang = (float) (ang * Math.PI / 180.0);
        float cos = (float) Math.Cos(ang);
        float sin = (float) Math.Sin(ang);
        float[,] saida = new float[,] {
            { 1,    0,   0, 0},
            { 0,  cos, sin, 0},
            { 0, -sin, cos, 0},
            { 0,    0,   0, 1}
        };
        return saida;
    }
    
    public static float[,] TrY(float ang /*em graus*/) {
        ang = (float) (ang * Math.PI / 180.0);
        float cos = (float) Math.Cos(ang);
        float sin = (float) Math.Sin(ang);
        float[,] saida = new float[,] {
            { cos, 0, -sin, 0},
            {   0, 1,    0, 0},
            { sin, 0,  cos, 0},
            {   0, 0,    0, 1}
        };
        return saida;
    }

    public static float[,] Tt(float dx, float dy, float dz /*em graus*/) {
        float[,] saida = new float[,] {
            {1, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 0, 1, 0},
            {dx,dy,dz,1}
        };
        return saida;
    }

    public static float[,] Ts(float sx, float sy, float sz /*em graus*/) {
        float[,] saida = new float[,] {
            {sx, 0, 0, 0},
            {0, sy, 0, 0},
            {0, 0, sz, 0},
            {0, 0,  0, 1}
        };
        return saida;
    }
    
    public static float[,] Tv3D(float theta, float phi, float rho) {
        
        theta = (float) (theta * Math.PI / 180.0);
        phi = (float) (phi * Math.PI / 180.0);
        float senPhi = (float)Math.Sin(phi);
        float senTheta = (float)Math.Sin(theta);
        float cosPhi = (float) Math.Cos(phi);
        float cosTheta = (float) Math.Cos(theta);
       
        float[,] saida = new float[,] {
            {-senTheta, -cosPhi*cosTheta, senPhi*cosTheta, 0},
            { cosTheta, -cosPhi*senTheta, senPhi*senTheta, 0},
            {        0,           senPhi,          cosPhi, 0},
            {        0,                0,            -rho, 1}
        };
         
        return saida;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public float[,] getDefinicao() {
        return definicao;
    }

    public void setDefinicao(float[,] definicao) {
        this.definicao = definicao;
    }


    public override String ToString() {
        return id;
    }

}
