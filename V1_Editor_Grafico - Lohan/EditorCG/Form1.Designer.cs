namespace EditorCG
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
            this.painelControle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.painelDesenho = new System.Windows.Forms.Panel();
            this.comboBox_lista = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btn_confirmaGeometria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_transform = new System.Windows.Forms.ComboBox();
            this.txt_NomeGeometria = new System.Windows.Forms.TextBox();
            this.txt_Dx = new System.Windows.Forms.TextBox();
            this.txt_dY = new System.Windows.Forms.TextBox();
            this.dX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AplicarTrans = new System.Windows.Forms.Button();
            this.painelControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelControle
            // 
            this.painelControle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelControle.Controls.Add(this.btn_AplicarTrans);
            this.painelControle.Controls.Add(this.label4);
            this.painelControle.Controls.Add(this.dX);
            this.painelControle.Controls.Add(this.txt_dY);
            this.painelControle.Controls.Add(this.txt_Dx);
            this.painelControle.Controls.Add(this.txt_NomeGeometria);
            this.painelControle.Controls.Add(this.comboBox_transform);
            this.painelControle.Controls.Add(this.label3);
            this.painelControle.Controls.Add(this.txt_Nome);
            this.painelControle.Controls.Add(this.label2);
            this.painelControle.Controls.Add(this.label1);
            this.painelControle.Controls.Add(this.btn_confirmaGeometria);
            this.painelControle.Controls.Add(this.txtX);
            this.painelControle.Controls.Add(this.txtY);
            this.painelControle.Controls.Add(this.button2);
            this.painelControle.Controls.Add(this.comboBox_lista);
            this.painelControle.Controls.Add(this.button1);
            this.painelControle.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelControle.Location = new System.Drawing.Point(0, 0);
            this.painelControle.Name = "painelControle";
            this.painelControle.Size = new System.Drawing.Size(861, 178);
            this.painelControle.TabIndex = 0;
            this.painelControle.Paint += new System.Windows.Forms.PaintEventHandler(this.painelControle_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar geometria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // painelDesenho
            // 
            this.painelDesenho.BackColor = System.Drawing.SystemColors.ControlText;
            this.painelDesenho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelDesenho.Location = new System.Drawing.Point(0, 178);
            this.painelDesenho.Name = "painelDesenho";
            this.painelDesenho.Size = new System.Drawing.Size(861, 307);
            this.painelDesenho.TabIndex = 1;
            // 
            // comboBox_lista
            // 
            this.comboBox_lista.FormattingEnabled = true;
            this.comboBox_lista.Location = new System.Drawing.Point(32, 12);
            this.comboBox_lista.Name = "comboBox_lista";
            this.comboBox_lista.Size = new System.Drawing.Size(121, 21);
            this.comboBox_lista.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Adicionar ponto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(110, 39);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(43, 20);
            this.txtY.TabIndex = 4;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(45, 39);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(40, 20);
            this.txtX.TabIndex = 5;
            // 
            // btn_confirmaGeometria
            // 
            this.btn_confirmaGeometria.Location = new System.Drawing.Point(159, 12);
            this.btn_confirmaGeometria.Name = "btn_confirmaGeometria";
            this.btn_confirmaGeometria.Size = new System.Drawing.Size(114, 21);
            this.btn_confirmaGeometria.TabIndex = 2;
            this.btn_confirmaGeometria.Text = "Confirmar geometria";
            this.btn_confirmaGeometria.UseVisualStyleBackColor = true;
            this.btn_confirmaGeometria.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(62, 100);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(91, 20);
            this.txt_Nome.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "nome:";
            // 
            // comboBox_transform
            // 
            this.comboBox_transform.FormattingEnabled = true;
            this.comboBox_transform.Location = new System.Drawing.Point(359, 42);
            this.comboBox_transform.Name = "comboBox_transform";
            this.comboBox_transform.Size = new System.Drawing.Size(121, 21);
            this.comboBox_transform.TabIndex = 10;
            // 
            // txt_NomeGeometria
            // 
            this.txt_NomeGeometria.Location = new System.Drawing.Point(359, 13);
            this.txt_NomeGeometria.Name = "txt_NomeGeometria";
            this.txt_NomeGeometria.Size = new System.Drawing.Size(121, 20);
            this.txt_NomeGeometria.TabIndex = 11;
            // 
            // txt_Dx
            // 
            this.txt_Dx.Location = new System.Drawing.Point(359, 80);
            this.txt_Dx.Name = "txt_Dx";
            this.txt_Dx.Size = new System.Drawing.Size(121, 20);
            this.txt_Dx.TabIndex = 12;
            // 
            // txt_dY
            // 
            this.txt_dY.Location = new System.Drawing.Point(359, 106);
            this.txt_dY.Name = "txt_dY";
            this.txt_dY.Size = new System.Drawing.Size(121, 20);
            this.txt_dY.TabIndex = 13;
            // 
            // dX
            // 
            this.dX.AutoSize = true;
            this.dX.Location = new System.Drawing.Point(295, 83);
            this.dX.Name = "dX";
            this.dX.Size = new System.Drawing.Size(61, 13);
            this.dX.TabIndex = 14;
            this.dX.Text = "Dx/Angulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dy:";
            // 
            // btn_AplicarTrans
            // 
            this.btn_AplicarTrans.Location = new System.Drawing.Point(359, 132);
            this.btn_AplicarTrans.Name = "btn_AplicarTrans";
            this.btn_AplicarTrans.Size = new System.Drawing.Size(121, 23);
            this.btn_AplicarTrans.TabIndex = 16;
            this.btn_AplicarTrans.Text = "Gerar Transformacao";
            this.btn_AplicarTrans.UseVisualStyleBackColor = true;
            this.btn_AplicarTrans.Click += new System.EventHandler(this.btn_AplicarTrans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 485);
            this.Controls.Add(this.painelDesenho);
            this.Controls.Add(this.painelControle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.painelControle.ResumeLayout(false);
            this.painelControle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelControle;
        private System.Windows.Forms.Panel painelDesenho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_lista;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirmaGeometria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_AplicarTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dX;
        private System.Windows.Forms.TextBox txt_dY;
        private System.Windows.Forms.TextBox txt_Dx;
        private System.Windows.Forms.TextBox txt_NomeGeometria;
        private System.Windows.Forms.ComboBox comboBox_transform;
    }
}

