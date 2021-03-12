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
    private List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();
    private List<Point2D> listaDePontos = new List<Point2D>();
    private List<Transformacoes> listaTrans = new List<Transformacoes>();
    //private Form1 classePrincipal = new Form1(); 

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
            TodasGeometrias();

            

            addGeometriaTeste();
            desenhaGeometrias();

            //Pen pen = new Pen(Brushes.Aqua);
            //g.DrawLine(pen, 10, 10, 200, 300);
        }
        public void TodasGeometrias()
        {

            if (int.Parse(comboBox_lista.SelectedValue.ToString()) == 4)
            {

                AddQuadrado(listaDePontos);
            }
            else
            
                if (int.Parse(comboBox_lista.SelectedValue.ToString()) == 2)
                {
                    AddReta(listaDePontos);
                } else if(int.Parse(comboBox_lista.SelectedValue.ToString()) == 3)
            {
                AddTriangulo(listaDePontos);
            }
            

            
           

        }

        public void TodasTrans()
        {
            Geometria geo = new Geometria();
            for (int i = 0; i < geometrias.Count; i++)
            {
                
                if (geometrias[i].getId() == txt_NomeGeometria.Text)
                {
                    geo = geometrias[i];
                }
            }
            if (int.Parse(comboBox_transform.SelectedValue.ToString()) == 0)
            {
                Transformadas.aplica(geo, Transformadas.Tr(float.Parse(txt_Dx.Text)));
            }
            else if (int.Parse(comboBox_transform.SelectedValue.ToString()) == 1)
            {
                Transformadas.aplica(geo, Transformadas.Ts(float.Parse(txt_Dx.Text), float.Parse(txt_dY.Text)));
            }
            else if (int.Parse(comboBox_transform.SelectedValue.ToString()) == 2)
            {
                Transformadas.aplica(geo, Transformadas.Tt(float.Parse(txt_Dx.Text), float.Parse(txt_dY.Text)));
            }
        }

        private void addGeometriaTeste()
        {
           /* Geometria geometria = new Geometria();


           


            Point2D p1 = new Point2D(5, 5);
            Point2D p2 = new Point2D(20, 5);
            Point2D p3 = new Point2D(10, 10);
            Point2D p4 = new Point2D(1, 2);
             geometria.setId("teste");
             geometria.setCor(new Pen(Brushes.Green));


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
            
            


            //teste de aplicação de transformada de rotação direto 

           // Geometria geometriaTeste = geometrias[1];
            

            //Transformadas.aplica(geometriaTeste, Transformadas.Tr(30));*/




        }

       public void Eixos()
        {

            Point2D p1 = new Point2D();
            Point2D p2 = new Point2D();
            Point2D p3 = new Point2D();
            Point2D p4 = new Point2D();

            Geometria geometria = new Geometria();

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
        }

        public void AddQuadrado(List<Point2D> listaDePontos)
        {
            Geometria geometria = new Geometria();
            for (int i = 0; i < 4; i++) {
               
                geometria.getPontos().Add(listaDePontos.ElementAt(i));
                }

            geometria.getArestas().Add(new Aresta(listaDePontos[0], listaDePontos[1]));
            geometria.getArestas().Add(new Aresta(listaDePontos[1], listaDePontos[2]));
            geometria.getArestas().Add(new Aresta(listaDePontos[2], listaDePontos[3]));
            geometria.getArestas().Add(new Aresta(listaDePontos[3], listaDePontos[0]));
            geometria.setId(txt_Nome.Text);
            geometria.setCor(new Pen(Brushes.Brown));

            geometrias.Add(geometria);




        }

        public void AddReta(List<Point2D> listaDePontos)
        {
            Geometria geometria = new Geometria();
            for (int i = 0; i < 2; i++)
            {

                geometria.getPontos().Add(listaDePontos.ElementAt(i));
            }

            geometria.getArestas().Add(new Aresta(listaDePontos[0], listaDePontos[1]));
            geometria.setId(txt_Nome.Text);
            geometria.setCor(new Pen(Brushes.Green));

            geometrias.Add(geometria);
        }

        public void AddTriangulo(List<Point2D> listaDePontos)
        {
            Geometria geometria = new Geometria();
            for (int i = 0; i < 3; i++)
            {

                geometria.getPontos().Add(listaDePontos.ElementAt(i));
            }

            geometria.getArestas().Add(new Aresta(listaDePontos[0], listaDePontos[1]));
            geometria.getArestas().Add(new Aresta(listaDePontos[1], listaDePontos[2]));
            geometria.getArestas().Add(new Aresta(listaDePontos[2], listaDePontos[0]));
           
            geometria.setId(txt_Nome.Text);
            geometria.setCor(new Pen(Brushes.Pink));

            geometrias.Add(geometria);
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
            
                Point2D ponto = new Point2D(float.Parse(txtX.Text), float.Parse(txtY.Text));
                listaDePontos.Add(ponto);
                txtX.Clear();
                txtY.Clear();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Eixos();

            FormaGeometrica formaGeometrica;
            formasGeometricas.Add(formaGeometrica = new FormaGeometrica("2 Linhas", "2"));
            formasGeometricas.Add(formaGeometrica = new FormaGeometrica("3 Linhas", "3"));
            formasGeometricas.Add(formaGeometrica = new FormaGeometrica("4 Linhas", "4"));
            Transformacoes transformacoes;
            listaTrans.Add(transformacoes = new Transformacoes("Rotacao", "0"));
            listaTrans.Add(transformacoes = new Transformacoes("Escala", "1"));
            listaTrans.Add(transformacoes = new Transformacoes("Translacao", "2"));



            comboBox_lista.ValueMember = "qtdPontos";
            comboBox_lista.DisplayMember = "nome";
            comboBox_lista.DataSource = formasGeometricas;

            comboBox_transform.ValueMember = "posicoes";
            comboBox_transform.DisplayMember = "nome";
            comboBox_transform.DataSource = listaTrans;
        }

        private void painelControle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            listaDePontos.Clear();

          
        }

        private void btn_AplicarTrans_Click(object sender, EventArgs e)
        {
            Graphics g = painelDesenho.CreateGraphics();

            g.Clear(Color.Black);
            initgr(g);
            //TodasGeometrias();

            TodasTrans();

            desenhaGeometrias();
            
        }
    }
}
