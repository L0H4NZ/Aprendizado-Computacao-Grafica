using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EditorCG
{
    public class Geometria
    {
        private List<Point2D> pontos = new List<Point2D>();
    private List<Aresta> arestas = new List<Aresta>();
    private String id;
    private Pen cor;
    public String strId { get; set; }
    public String strPontos { get; set; }

    public List<Point2D> getPontos() {
        return pontos;
    }

    public void setPontos(List<Point2D> pontos) {
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

    public Pen getCor() {
        return cor;
    }

    public void setCor(Pen cor) {
        this.cor = cor;
    }
    }
}
