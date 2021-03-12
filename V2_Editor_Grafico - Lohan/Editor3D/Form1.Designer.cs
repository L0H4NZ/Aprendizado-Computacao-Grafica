namespace Editor3D
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_novaGeometria = new System.Windows.Forms.Button();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_z = new System.Windows.Forms.TextBox();
            this.btn_adcPonto = new System.Windows.Forms.Button();
            this.comboBox_Cor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Geometria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_getId = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.comboBox_transformada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Transformada = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tZ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tX = new System.Windows.Forms.TextBox();
            this.btn_salvarCord = new System.Windows.Forms.Button();
            this.btn_IniciarAnimacao = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tempo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(11, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 346);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(32, 6);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(148, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(296, 6);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(86, 104);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.Text = "Salvar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_novaGeometria
            // 
            this.btn_novaGeometria.Location = new System.Drawing.Point(186, 6);
            this.btn_novaGeometria.Name = "btn_novaGeometria";
            this.btn_novaGeometria.Size = new System.Drawing.Size(94, 20);
            this.btn_novaGeometria.TabIndex = 4;
            this.btn_novaGeometria.Text = "Nova Geometria";
            this.btn_novaGeometria.UseVisualStyleBackColor = true;
            this.btn_novaGeometria.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(35, 90);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(31, 20);
            this.txt_x.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(92, 90);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(31, 20);
            this.txt_y.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Z";
            // 
            // txt_z
            // 
            this.txt_z.Location = new System.Drawing.Point(149, 90);
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(31, 20);
            this.txt_z.TabIndex = 10;
            // 
            // btn_adcPonto
            // 
            this.btn_adcPonto.Location = new System.Drawing.Point(186, 90);
            this.btn_adcPonto.Name = "btn_adcPonto";
            this.btn_adcPonto.Size = new System.Drawing.Size(94, 21);
            this.btn_adcPonto.TabIndex = 12;
            this.btn_adcPonto.Text = "Adicionar Ponto";
            this.btn_adcPonto.UseVisualStyleBackColor = true;
            this.btn_adcPonto.Click += new System.EventHandler(this.btn_adcPonto_Click);
            // 
            // comboBox_Cor
            // 
            this.comboBox_Cor.FormattingEnabled = true;
            this.comboBox_Cor.Location = new System.Drawing.Point(32, 32);
            this.comboBox_Cor.Name = "comboBox_Cor";
            this.comboBox_Cor.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Cor.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cor";
            // 
            // comboBox_Geometria
            // 
            this.comboBox_Geometria.FormattingEnabled = true;
            this.comboBox_Geometria.Location = new System.Drawing.Point(32, 59);
            this.comboBox_Geometria.Name = "comboBox_Geometria";
            this.comboBox_Geometria.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Geometria.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID do Objeto";
            // 
            // txt_getId
            // 
            this.txt_getId.Location = new System.Drawing.Point(481, 7);
            this.txt_getId.Name = "txt_getId";
            this.txt_getId.Size = new System.Drawing.Size(121, 20);
            this.txt_getId.TabIndex = 17;
            // 
            // comboBox_transformada
            // 
            this.comboBox_transformada.FormattingEnabled = true;
            this.comboBox_transformada.Location = new System.Drawing.Point(481, 35);
            this.comboBox_transformada.Name = "comboBox_transformada";
            this.comboBox_transformada.Size = new System.Drawing.Size(121, 21);
            this.comboBox_transformada.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Transformada";
            // 
            // btn_Transformada
            // 
            this.btn_Transformada.Location = new System.Drawing.Point(498, 87);
            this.btn_Transformada.Name = "btn_Transformada";
            this.btn_Transformada.Size = new System.Drawing.Size(75, 23);
            this.btn_Transformada.TabIndex = 20;
            this.btn_Transformada.Text = "Transformar";
            this.btn_Transformada.UseVisualStyleBackColor = true;
            this.btn_Transformada.Click += new System.EventHandler(this.btn_Transformada_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Z";
            // 
            // txt_tZ
            // 
            this.txt_tZ.Location = new System.Drawing.Point(584, 62);
            this.txt_tZ.Name = "txt_tZ";
            this.txt_tZ.Size = new System.Drawing.Size(31, 20);
            this.txt_tZ.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Y";
            // 
            // txt_tY
            // 
            this.txt_tY.Location = new System.Drawing.Point(527, 62);
            this.txt_tY.Name = "txt_tY";
            this.txt_tY.Size = new System.Drawing.Size(31, 20);
            this.txt_tY.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "X";
            // 
            // txt_tX
            // 
            this.txt_tX.Location = new System.Drawing.Point(470, 62);
            this.txt_tX.Name = "txt_tX";
            this.txt_tX.Size = new System.Drawing.Size(31, 20);
            this.txt_tX.TabIndex = 21;
            // 
            // btn_salvarCord
            // 
            this.btn_salvarCord.Location = new System.Drawing.Point(636, 29);
            this.btn_salvarCord.Name = "btn_salvarCord";
            this.btn_salvarCord.Size = new System.Drawing.Size(103, 23);
            this.btn_salvarCord.TabIndex = 27;
            this.btn_salvarCord.Text = "Salvar Cordenada";
            this.btn_salvarCord.UseVisualStyleBackColor = true;
            this.btn_salvarCord.Click += new System.EventHandler(this.btn_salvarCord_Click);
            // 
            // btn_IniciarAnimacao
            // 
            this.btn_IniciarAnimacao.Location = new System.Drawing.Point(636, 58);
            this.btn_IniciarAnimacao.Name = "btn_IniciarAnimacao";
            this.btn_IniciarAnimacao.Size = new System.Drawing.Size(103, 23);
            this.btn_IniciarAnimacao.TabIndex = 29;
            this.btn_IniciarAnimacao.Text = "Inicar";
            this.btn_IniciarAnimacao.UseVisualStyleBackColor = true;
            this.btn_IniciarAnimacao.Click += new System.EventHandler(this.btn_IniciarAnimacao_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(661, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Animacao";
            // 
            // txt_tempo
            // 
            this.txt_tempo.Location = new System.Drawing.Point(698, 90);
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.Size = new System.Drawing.Size(41, 20);
            this.txt_tempo.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(633, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Repeticoes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 475);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_tempo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_IniciarAnimacao);
            this.Controls.Add(this.btn_salvarCord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tZ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_tX);
            this.Controls.Add(this.btn_Transformada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_transformada);
            this.Controls.Add(this.txt_getId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Geometria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Cor);
            this.Controls.Add(this.btn_adcPonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_z);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.btn_novaGeometria);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_novaGeometria;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_z;
        private System.Windows.Forms.Button btn_adcPonto;
        private System.Windows.Forms.ComboBox comboBox_Cor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Geometria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_getId;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox comboBox_transformada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Transformada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tX;
        private System.Windows.Forms.Button btn_salvarCord;
        private System.Windows.Forms.Button btn_IniciarAnimacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tempo;
        private System.Windows.Forms.Label label12;
    }
}

