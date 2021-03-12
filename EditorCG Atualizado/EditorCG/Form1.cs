using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditorCG
{
    public partial class Form1 : Form
    {
        private List<Geometria> geometrias = new List<Geometria>();

    private float realWidth = 100.0f;
    private float realHeight = 100.0f;
    private float centerX;
    private float centerY;
    private float tamPixel;
    private Graphics context;

    private Point2D current = new Point2D();

    private void initgr(Graphics g) {

        Size d = this.Size;
        tamPixel = Math.Max(realWidth / (d.Width - 1), realHeight / (d.Height - 1));
        centerX = d.Width / 2;
        centerY = d.Height / 2;
        context = g;
    }

    private int ix(float x) {
        return (int) Math.Round(x / tamPixel + centerX);
    }

    private int iy(float y) {
        return (int) Math.Round(centerY - y / tamPixel);
    }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = painelDesenho.CreateGraphics();

            g.Clear(Color.Black);
            initgr(g);
            addGeometriaTeste();
            desenhaGeometrias();

            //Pen pen = new Pen(Brushes.Aqua);
            //g.DrawLine(pen, 10, 10, 200, 300);
        }

        private void addGeometriaTeste()
        {
            Geometria geometria = new Geometria();
            geometria.setId("teste");
            geometria.setCor(new Pen(Brushes.Green));

            Point2D p1 = new Point2D(5, 5);
            Point2D p2 = new Point2D(20, 5);
            Point2D p3 = new Point2D(10, 10);

            geometria.getPontos().Add(p1);
            geometria.getPontos().Add(p2);
            geometria.getPontos().Add(p3);

            geometria.getArestas().Add(new Aresta(p1, p2));
            geometria.getArestas().Add(new Aresta(p2, p3));
            geometria.getArestas().Add(new Aresta(p3, p1));

            geometrias.Add(geometria);

            ////

            geometria = new Geometria();
            geometria.setId("pequenoRetangulo");
            geometria.setCor(new Pen(Brushes.Blue));

            p1 = new Point2D(1, 1);
            p2 = new Point2D(3, 1);
            p3 = new Point2D(3, 2);
            Point2D p4 = new Point2D(1, 2);

            geometria.getPontos().Add(p1);
            geometria.getPontos().Add(p2);
            geometria.getPontos().Add(p3);
            geometria.getPontos().Add(p4);

            geometria.getArestas().Add(new Aresta(p1, p2));
            geometria.getArestas().Add(new Aresta(p2, p3));
            geometria.getArestas().Add(new Aresta(p3, p4));
            geometria.getArestas().Add(new Aresta(p4, p1));

            geometrias.Add(geometria);

            //eixos

            geometria = new Geometria();
            geometria.setId("eixos");
            geometria.setCor(new Pen(Brushes.White));

            p1 = new Point2D(0, 10000);
            p2 = new Point2D(0, -10000);
            p3 = new Point2D(-10000, 0);
            p4 = new Point2D(10000, 0);

            geometria.getPontos().Add(p1);
            geometria.getPontos().Add(p2);
            geometria.getPontos().Add(p3);
            geometria.getPontos().Add(p4);

            geometria.getArestas().Add(new Aresta(p1, p2));
            geometria.getArestas().Add(new Aresta(p3, p4));

            geometrias.Add(geometria);

            //teste de aplicação de transformada de rotação direto 

            Geometria geometriaTeste = geometrias[1];

            Transformadas.aplica(geometriaTeste, Transformadas.Tt(0, 10));


        }

        private void desenhaGeometrias() {
            foreach (Geometria geometria in geometrias) {
                Pen pen = geometria.getCor();
                foreach (Aresta aresta in geometria.getArestas()) {
                    context.DrawLine(pen, ix(aresta.p1.getX()), iy(aresta.p1.getY()), 
                        ix(aresta.p2.getX()), iy(aresta.p2.getY()));
                }
            }
    }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Graphics g = painelDesenho.CreateGraphics();

            g.Clear(Color.Black);
            initgr(g);
            //addGeometriaTeste();
            desenhaGeometrias();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
