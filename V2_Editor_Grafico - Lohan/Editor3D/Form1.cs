using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Editor3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.geometria = new Geometria();
        }
        //Lista de geometrias
        private List<Geometria> geometrias = new List<Geometria>();

        private List<Transformada> transformadas = new List<Transformada>();

        private List<CoordenadasAnimacao> coordenadasAnimacoes = new List<CoordenadasAnimacao>();

        //Variaveis com valores para a tela
        private float realWidth = 1.0f;
        private float realHeight = 1.0f;
        private float centerX;
        private float centerY;
        private float tamPixel;
        private Graphics context;
        private float theta, phi, rho, d;
    
        private Transformada t3d = new Transformada();
        private Point3D current = new Point3D();

        //Cria as cordenadas da tela
        private void initgr() {

            Size d = panel1.Size;
            tamPixel = Math.Max(realWidth / (d.Width - 1), realHeight / (d.Height - 1));
            centerX = d.Width / 2;
            centerY = d.Height / 2;
        
        }

        private int ix(float x) {
            return (int) Math.Round(x / tamPixel + centerX);
        }

        private int iy(float y) {
            return (int) Math.Round(centerY - y / tamPixel);
        }

        //Dentro do foreach ele chama o metodo Desenha Geometria que desenha todas as geometrias
        private void desenhaGeometrias() {

            // panel1.Invalidate();
            panel1.Refresh();
            foreach (Geometria geometria in geometrias) {
            
                desenhaGeometria(geometria);
            }
        }

        //desenha a geometria passada por parametro
        private void desenhaGeometria(Geometria geometria) {

            //context.setColor(geometria.getCor());

            
            foreach (Aresta aresta in geometria.getArestas()) {
            
                //aqui preciso de dois pontos após transformada de visualização
            
                
                Point3D p1 = new Point3D(CgUtils.mult(geometria.getPontos()[aresta.pInicial].getValor(), t3d.getDefinicao()));
                Point3D p2 = new Point3D(CgUtils.mult(geometria.getPontos()[aresta.pFinal].getValor(), t3d.getDefinicao()));

               
                panel1.CreateGraphics().DrawLine(
                        new Pen(Brushes.Aqua),
                        ix(-d*p1.getX()/p1.getZ()), 
                        iy(-d*p1.getY()/p1.getZ()), 
                        ix(-d*p2.getX()/p2.getZ()), 
                        iy(-d*p2.getY()/p2.getZ()));
            }
        }

        public List<Geometria> getGeometrias()
        {
            return geometrias;
        }

        public void setGeometrias(List<Geometria> geometrias)
        {
            this.geometrias = geometrias;
        }

        public List<Transformada> getTransformadas()
        {
            return transformadas;
        }

        public void setTransformadas(List<Transformada> transformadas)
        {
            this.transformadas = transformadas;
        }

        private Geometria getGeometriaById(String id) {

            foreach (Geometria g in geometrias) {

                if (id != null && id == g.getId()) {

                    return g;
                }
            }
            return null;
         }

        //Metodo que cria uma nova geometria ou edita os dados ja existentes
        public void addGeometria(Geometria geometria)
        {
            Geometria g = getGeometriaById(geometria.getId());

            if (g != null)
            {
                geometrias[geometrias.IndexOf(g)] = geometria;
            }
            else
            {
                geometrias.Add(geometria);
            }
        }
        //Quando clickar no botao 
        private void iniciaGeometrias()
        {
            
            //Geometria armazena todo o objeto: nome, id, cor, pontos, e arestas
            Geometria geometria = new Geometria();
            geometria.setId("cubo1");
            geometria.setCor(Color.Red);

            //Pega os pontos x, y, z
            geometria.getPontos().Add(new Point3D(1, 1, 1));
            geometria.getPontos().Add(new Point3D(1, 1, -1));
            geometria.getPontos().Add(new Point3D(-1, 1, -1));
            geometria.getPontos().Add(new Point3D(-1, 1, 1));

            geometria.getPontos().Add(new Point3D(1, -1, 1));
            geometria.getPontos().Add(new Point3D(1, -1, -1));
            geometria.getPontos().Add(new Point3D(-1, -1, -1));
            geometria.getPontos().Add(new Point3D(-1, -1, 1));

            //liga as arestas com os pontos
            geometria.getArestas().Add(new Aresta(0, 1));
            geometria.getArestas().Add(new Aresta(1, 2));
            geometria.getArestas().Add(new Aresta(2, 3));
            geometria.getArestas().Add(new Aresta(3, 0));

            geometria.getArestas().Add(new Aresta(4, 5));
            geometria.getArestas().Add(new Aresta(5, 6));
            geometria.getArestas().Add(new Aresta(6, 7));
            geometria.getArestas().Add(new Aresta(7, 4));

            geometria.getArestas().Add(new Aresta(0, 4));
            geometria.getArestas().Add(new Aresta(1, 5));
            geometria.getArestas().Add(new Aresta(2, 6));
            geometria.getArestas().Add(new Aresta(3, 7));

            //Coloca o objeto na lista de objetos
            this.addGeometria(geometria); // getGeometrias().Add(geometria);

        }

        public Geometria Cores()
        {
            Geometria geometria = new Geometria();
            if(comboBox_Cor.Text == "Blue")
            {
                geometria.setCor(Color.Blue);
            } else if(comboBox_Cor.Text == "Red")
            {
                geometria.setCor(Color.Red);
            } else if(comboBox_Cor.Text == "Purple")
            {
                geometria.setCor(Color.Purple);
            } else if(comboBox_Cor.Text == "Yellow")
            {
                geometria.setCor(Color.Yellow);
            }
            return geometria;

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Cor.Items.Add("Blue");
            comboBox_Cor.Items.Add("Red");
            comboBox_Cor.Items.Add("Purple");
            comboBox_Cor.Items.Add("Yellow");

            comboBox_Geometria.Items.Add("Cubo");
            comboBox_Geometria.Items.Add("Piramide");
            comboBox_Geometria.Items.Add("Prisma");
            comboBox_Geometria.Items.Add("Losango");

            comboBox_transformada.Items.Add("Rotacao");
            comboBox_transformada.Items.Add("Translacao");
            comboBox_transformada.Items.Add("Scala");






        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        Geometria geometria;
       
        //Cria uma nova instancia do objeto
        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.geometria = new Geometria();
        }

        //Adiciona um ponto na lista de pontos do obj geometria
        private void btn_adcPonto_Click(object sender, EventArgs e)
        {
           

            this.geometria.getPontos().Add(new Point3D(float.Parse(txt_x.Text), float.Parse(txt_y.Text), float.Parse(txt_z.Text)));
        }

        //Quando clicar no botao, cria o objeto com os valores setados
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Geometria corGeometria = Cores();


            if (comboBox_Geometria.Text == "Cubo")
            {
                this.geometria.setId(txt_nome.Text);
                this.geometria.setCor(corGeometria.getCor());
                this.geometria.getArestas().Add(new Aresta(0, 1));
                this.geometria.getArestas().Add(new Aresta(1, 2));
                this.geometria.getArestas().Add(new Aresta(2, 3));
                this.geometria.getArestas().Add(new Aresta(3, 0));

                this.geometria.getArestas().Add(new Aresta(4, 5));
                this.geometria.getArestas().Add(new Aresta(5, 6));
                this.geometria.getArestas().Add(new Aresta(6, 7));
                this.geometria.getArestas().Add(new Aresta(7, 4));

                this.geometria.getArestas().Add(new Aresta(0, 4));
                this.geometria.getArestas().Add(new Aresta(1, 5));
                this.geometria.getArestas().Add(new Aresta(2, 6));
                this.geometria.getArestas().Add(new Aresta(3, 7));
                this.addGeometria(geometria);

            
            if (!iniciou)
            {
                initgr();
                //iniciaGeometrias();
                float theta = 15.0f;
                float phi = 15.0f;
                float rho = 100.0f;
                float d = 10.0f;

                configTransformada(theta, phi, rho, d);
                iniciou = true;
            }

            desenhaGeometrias();

                }

            if (comboBox_Geometria.Text == "Losango")
            {
                this.geometria.setId(txt_nome.Text);
                this.geometria.setCor(corGeometria.getCor());
                this.geometria.getArestas().Add(new Aresta(0, 1));
                this.geometria.getArestas().Add(new Aresta(0, 3));
                this.geometria.getArestas().Add(new Aresta(0, 4));
                this.geometria.getArestas().Add(new Aresta(0, 5));

                this.geometria.getArestas().Add(new Aresta(1, 2));
                this.geometria.getArestas().Add(new Aresta(1, 4));
                this.geometria.getArestas().Add(new Aresta(1, 5));
                this.geometria.getArestas().Add(new Aresta(2, 3));

                this.geometria.getArestas().Add(new Aresta(2, 4));
                this.geometria.getArestas().Add(new Aresta(2, 5));
                this.geometria.getArestas().Add(new Aresta(3, 4));
                this.geometria.getArestas().Add(new Aresta(3, 5));
                this.addGeometria(geometria);


                if (!iniciou)
                {
                    initgr();
                    //iniciaGeometrias();
                    float theta = 15.0f;
                    float phi = 15.0f;
                    float rho = 100.0f;
                    float d = 10.0f;

                    configTransformada(theta, phi, rho, d);
                    iniciou = true;
                }

                desenhaGeometrias();

            }
            if (comboBox_Geometria.Text == "Piramide")
            {
                this.geometria.setId(txt_nome.Text);
                this.geometria.setCor(corGeometria.getCor());
                this.geometria.getArestas().Add(new Aresta(0, 1));
                this.geometria.getArestas().Add(new Aresta(0, 2));
                this.geometria.getArestas().Add(new Aresta(0, 3));
                this.geometria.getArestas().Add(new Aresta(0, 4));

                this.geometria.getArestas().Add(new Aresta(1, 2));
                this.geometria.getArestas().Add(new Aresta(1, 3));
                this.geometria.getArestas().Add(new Aresta(2, 4));
                this.geometria.getArestas().Add(new Aresta(3, 4));

                this.addGeometria(geometria);


                if (!iniciou)
                {
                    initgr();
                    //iniciaGeometrias();
                    float theta = 15.0f;
                    float phi = 15.0f;
                    float rho = 100.0f;
                    float d = 10.0f;

                    configTransformada(theta, phi, rho, d);
                    iniciou = true;
                }

                desenhaGeometrias();

            }
            if (comboBox_Geometria.Text == "Prisma")
            {
                this.geometria.setId(txt_nome.Text);
                this.geometria.setCor(corGeometria.getCor());
                this.geometria.getArestas().Add(new Aresta(0, 1));
                this.geometria.getArestas().Add(new Aresta(0, 2));
                this.geometria.getArestas().Add(new Aresta(0, 3));
                this.geometria.getArestas().Add(new Aresta(1, 2));

                this.geometria.getArestas().Add(new Aresta(1, 4));
                this.geometria.getArestas().Add(new Aresta(2, 5));
                this.geometria.getArestas().Add(new Aresta(3, 4));
                this.geometria.getArestas().Add(new Aresta(3, 5));
                this.geometria.getArestas().Add(new Aresta(4, 5));

                this.addGeometria(geometria);


                if (!iniciou)
                {
                    initgr();
                    //iniciaGeometrias();
                    float theta = 15.0f;
                    float phi = 15.0f;
                    float rho = 100.0f;
                    float d = 10.0f;

                    configTransformada(theta, phi, rho, d);
                    iniciou = true;
                }

                desenhaGeometrias();

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Transformada objTransformada = new Transformada();

        //Aplicar transformacao
        private void btn_Transformada_Click(object sender, EventArgs e)
        {
            if (comboBox_transformada.Text == "Rotacao")
            {
                for (int i = 0; i < geometrias.Count(); i++)
                {
                    if (geometrias[i].getId() == txt_getId.Text)
                    {
                        if (txt_tZ.Text == "") { txt_tZ.Text = "0"; }
                        if (txt_tX.Text == "") { txt_tX.Text = "0"; }
                        if (txt_tY.Text == "") { txt_tY.Text = "0"; }
                        objTransformada.setDefinicao(Transformada.TrZ(int.Parse(txt_tZ.Text)));
                        geometrias[i].aplica(objTransformada);
                        objTransformada.setDefinicao(Transformada.TrX(int.Parse(txt_tX.Text)));
                        geometrias[i].aplica(objTransformada);
                        objTransformada.setDefinicao(Transformada.TrY(int.Parse(txt_tY.Text)));
                        geometrias[i].aplica(objTransformada);
                        addGeometria(geometrias[i]);
                        desenhaGeometrias();
                    }
                }
            }
            if (comboBox_transformada.Text == "Translacao")
            {
                for (int i = 0; i < geometrias.Count(); i++)
                {
                    if (geometrias[i].getId() == txt_getId.Text)
                    {
                        if (txt_tZ.Text == "") { txt_tZ.Text = "0"; }
                        if (txt_tX.Text == "") { txt_tX.Text = "0"; }
                        if (txt_tY.Text == "") { txt_tY.Text = "0"; }
                        objTransformada.setDefinicao(Transformada.Tt(float.Parse(txt_tX.Text), float.Parse(txt_tY.Text), float.Parse(txt_tZ.Text)));
                        geometrias[i].aplica(objTransformada);
                        addGeometria(geometrias[i]);
                        desenhaGeometrias();
                    }
                }
                
            }
            if (comboBox_transformada.Text == "Scala")
            {
                for (int i = 0; i < geometrias.Count(); i++)
                {
                    if (geometrias[i].getId() == txt_getId.Text)
                    {
                        if (txt_tZ.Text == "") { txt_tZ.Text = "1"; }
                        if (txt_tX.Text == "") { txt_tX.Text = "1"; }
                        if (txt_tY.Text == "") { txt_tY.Text = "1"; }
                        objTransformada.setDefinicao(Transformada.Ts(float.Parse(txt_tX.Text), float.Parse(txt_tY.Text), float.Parse(txt_tZ.Text)));
                        geometrias[i].aplica(objTransformada);
                        addGeometria(geometrias[i]);
                        desenhaGeometrias();
                        
                    }
                }

            }

        }


        bool animacao = false;

        //Inicia todas as animacoes de todas as geometrias que foram salvas
        private void btn_IniciarAnimacao_Click(object sender, EventArgs e)
        {
            this.animacao = true;
            int count = 0;
            int tempo = 0;
            if(txt_tempo.Text == "")
            {
                txt_tempo.Text = "0";
            }
            tempo = int.Parse(txt_tempo.Text);
            while (count < tempo)
            {
               
                for (int j = 0; j < coordenadasAnimacoes.Count(); j++)
                {
                    for (int i = 0; i < geometrias.Count(); i++)
                    {
                        if (geometrias[i].getId() == coordenadasAnimacoes[j].nome)
                        {
                            objTransformada.setDefinicao(Transformada.TrZ(coordenadasAnimacoes[j].trZ));
                            geometrias[i].aplica(objTransformada);
                            addGeometria(geometrias[i]);
                            objTransformada.setDefinicao(Transformada.TrX(coordenadasAnimacoes[j].trX));
                            geometrias[i].aplica(objTransformada);
                            addGeometria(geometrias[i]);
                            objTransformada.setDefinicao(Transformada.TrY(coordenadasAnimacoes[j].trY));
                            geometrias[i].aplica(objTransformada);
                            addGeometria(geometrias[i]);
                            objTransformada.setDefinicao(Transformada.Tt(coordenadasAnimacoes[j].ttX, coordenadasAnimacoes[j].ttY, coordenadasAnimacoes[j].ttZ));
                            geometrias[i].aplica(objTransformada);
                            addGeometria(geometrias[i]);
                            objTransformada.setDefinicao(Transformada.Ts(coordenadasAnimacoes[j].tsX, coordenadasAnimacoes[j].tsY, coordenadasAnimacoes[j].tsZ));
                            geometrias[i].aplica(objTransformada);
                            addGeometria(geometrias[i]);
                        }
                    }
                    desenhaGeometrias();
                }
                Thread.Sleep(100);
                count++;
            }
        }

        //float trX, trY, trZ, ttX, ttY, ttZ, tsX, tsY, tsZ;

        private void btn_PausarAnimacao_Click(object sender, EventArgs e)
        {
     
        }

        //Cria uma nova animacao ou modifica uma ja existente
        public int NomeAnimacao(String nome)
        {
            bool contem = false;
            int local = 0;
            for(int i = 0; i < coordenadasAnimacoes.Count(); i++)
            {
               if(coordenadasAnimacoes[i].nome == nome)
                {
                    contem = true;
                    local = i;
                    return local;
                }
            }
            if (contem == false)
            {
                coordenadasAnimacoes.Add(new CoordenadasAnimacao(nome));
                for (int i = 0; i < coordenadasAnimacoes.Count(); i++)
                {
                    if (coordenadasAnimacoes[i].nome == nome)
                    {
                        contem = true;
                        local = i;
                    }
                }

            }

            return local;
            

        }
        //Salva dados de uma animacao
        private void btn_salvarCord_Click(object sender, EventArgs e)
        {
            int local;
            local = NomeAnimacao(txt_getId.Text);

           
            if (comboBox_transformada.Text == "Rotacao")
            {
               
                        if (txt_tZ.Text == "") { txt_tZ.Text = "0"; }
                        if (txt_tX.Text == "") { txt_tX.Text = "0"; }
                        if (txt_tY.Text == "") { txt_tY.Text = "0"; }

                        this.coordenadasAnimacoes[local].trX = float.Parse(txt_tX.Text);
                        this.coordenadasAnimacoes[local].trY = float.Parse(txt_tY.Text);
                        this.coordenadasAnimacoes[local].trZ = float.Parse(txt_tZ.Text);
                  
            }
            if (comboBox_transformada.Text == "Translacao")
            {
                
                        if (txt_tZ.Text == "") { txt_tZ.Text = "0"; }
                        if (txt_tX.Text == "") { txt_tX.Text = "0"; }
                        if (txt_tY.Text == "") { txt_tY.Text = "0"; }

                        this.coordenadasAnimacoes[local].ttX = float.Parse(txt_tX.Text);
                        this.coordenadasAnimacoes[local].ttY = float.Parse(txt_tY.Text);
                        this.coordenadasAnimacoes[local].ttZ = float.Parse(txt_tZ.Text);
               

            }
            if (comboBox_transformada.Text == "Scala")
            {
               
                        if (txt_tZ.Text == "") { txt_tZ.Text = "1"; }
                        if (txt_tX.Text == "") { txt_tX.Text = "1"; }
                        if (txt_tY.Text == "") { txt_tY.Text = "1"; }
                        this.coordenadasAnimacoes[local].tsX = float.Parse(txt_tX.Text);
                        this.coordenadasAnimacoes[local].tsY = float.Parse(txt_tY.Text);
                        this.coordenadasAnimacoes[local].tsZ = float.Parse(txt_tZ.Text);

            }
        }

        public void configTransformada(float theta, float phi, float rho, float d)
        {

            this.theta = theta;
            this.phi = phi;
            this.rho = rho;
            this.d = d;

            t3d.setDefinicao(Transformada.Tv3D(theta, phi, rho));

            CgUtils.show(t3d.getDefinicao());
        }

        //Ao clickar no botao gera todas a geometrias 
        Boolean iniciou = false;
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = panel1.CreateGraphics();
            //Pen p = new Pen(Brushes.Aqua);
            //g.DrawLine(p, 10, 10, 300, 300);

            if (!iniciou)
            {
                initgr();
                iniciaGeometrias();
                float theta = 0.0f;
                float phi = 0.0f;
                float rho = 100.0f;
                float d = 10.0f;
               

                configTransformada(theta, phi, rho, d);
                iniciou = true;
            }

            desenhaGeometrias();

        }
    }
}
