using System.Collections.Generic;
using System;
using System.Drawing;


public class Geometria {

    private List<Point3D> pontos = new List<Point3D>();
    private List<Aresta> arestas = new List<Aresta>();
    private String id;
    private Color cor;
    
    public void aplica(Transformada transformada){
        
        foreach (Point3D ponto in this.getPontos()) {
            ponto.setValor(CgUtils.mult(ponto.getValor(), transformada.getDefinicao()));
        }
    }

    public List<Point3D> getPontos() {
        return pontos;
    }

    public void setPontos(List<Point3D> pontos) {
        this.pontos = pontos;
    }

    public List<Aresta> getArestas() {
        return arestas;
    }

    public void setArestas(List<Aresta> arestas) {
        this.arestas = arestas;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public Color getCor() {
        return cor;
    }

    public void setCor(Color cor) {
        this.cor = cor;
    }

}
