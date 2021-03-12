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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.painelControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelControle
            // 
            this.painelControle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelControle.Controls.Add(this.comboBox1);
            this.painelControle.Controls.Add(this.button1);
            this.painelControle.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelControle.Location = new System.Drawing.Point(0, 0);
            this.painelControle.Name = "painelControle";
            this.painelControle.Size = new System.Drawing.Size(861, 178);
            this.painelControle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.painelControle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelControle;
        private System.Windows.Forms.Panel painelDesenho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

