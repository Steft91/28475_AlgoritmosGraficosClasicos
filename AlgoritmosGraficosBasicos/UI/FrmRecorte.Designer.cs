namespace AlgoritmosGraficosBasicos.UI
{
    partial class FrmRecorte
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNLN = new System.Windows.Forms.Button();
            this.btnLiangBarsky = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btnNLN);
            this.groupBox2.Controls.Add(this.btnLiangBarsky);
            this.groupBox2.Controls.Add(this.btnCortar);
            this.groupBox2.Controls.Add(this.btnResetear);
            this.groupBox2.Location = new System.Drawing.Point(553, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 187);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Botones";
            // 
            // btnNLN
            // 
            this.btnNLN.BackColor = System.Drawing.Color.Thistle;
            this.btnNLN.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNLN.Location = new System.Drawing.Point(74, 76);
            this.btnNLN.Name = "btnNLN";
            this.btnNLN.Size = new System.Drawing.Size(112, 49);
            this.btnNLN.TabIndex = 10;
            this.btnNLN.Text = " Cortar NLN";
            this.btnNLN.UseVisualStyleBackColor = false;
            this.btnNLN.Click += new System.EventHandler(this.btnNLN_Click);
            // 
            // btnLiangBarsky
            // 
            this.btnLiangBarsky.BackColor = System.Drawing.Color.Thistle;
            this.btnLiangBarsky.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiangBarsky.Location = new System.Drawing.Point(141, 21);
            this.btnLiangBarsky.Name = "btnLiangBarsky";
            this.btnLiangBarsky.Size = new System.Drawing.Size(112, 49);
            this.btnLiangBarsky.TabIndex = 9;
            this.btnLiangBarsky.Text = " Cortar LiangBarsky";
            this.btnLiangBarsky.UseVisualStyleBackColor = false;
            this.btnLiangBarsky.Click += new System.EventHandler(this.btnLiangBarsky_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.BackColor = System.Drawing.Color.Thistle;
            this.btnCortar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortar.Location = new System.Drawing.Point(6, 21);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(112, 49);
            this.btnCortar.TabIndex = 8;
            this.btnCortar.Text = " Cortar Cohen";
            this.btnCortar.UseVisualStyleBackColor = false;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnResetear.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.Location = new System.Drawing.Point(74, 131);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(112, 35);
            this.btnResetear.TabIndex = 6;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.txtY1);
            this.groupBox4.Controls.Add(this.txtX1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(553, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 93);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Coordenada del segundo punto";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(96, 61);
            this.txtY1.Name = "txtY1";
            this.txtY1.ReadOnly = true;
            this.txtY1.Size = new System.Drawing.Size(125, 22);
            this.txtY1.TabIndex = 4;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(96, 30);
            this.txtX1.Name = "txtX1";
            this.txtX1.ReadOnly = true;
            this.txtX1.Size = new System.Drawing.Size(125, 22);
            this.txtX1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(19, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "X1 :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtY0);
            this.groupBox1.Controls.Add(this.txtX0);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(553, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenada del primer punto";
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(74, 60);
            this.txtY0.Name = "txtY0";
            this.txtY0.ReadOnly = true;
            this.txtY0.Size = new System.Drawing.Size(138, 22);
            this.txtY0.TabIndex = 2;
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(74, 29);
            this.txtX0.Name = "txtX0";
            this.txtX0.ReadOnly = true;
            this.txtX0.Size = new System.Drawing.Size(138, 22);
            this.txtX0.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y0 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X0 :";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.picCanvas);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox3.Location = new System.Drawing.Point(65, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 392);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Lavender;
            this.picCanvas.Location = new System.Drawing.Point(41, 50);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(329, 313);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccione 2 puntos en el gráfico para:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(775, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "- Visualizar sus coordenadas, dónde la esquina superior izquierda es (0,0) y todo" +
    "s los cuadrantes son ejes \r\npositivos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(455, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "- Elija el recorte que se pretende realizar y visualice el corte";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Lavender;
            this.label8.Font = new System.Drawing.Font("Stork Delivery", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(342, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 40);
            this.label8.TabIndex = 45;
            this.label8.Text = "Algoritmos de Recorte";
            // 
            // FrmRecorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 603);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmRecorte";
            this.Text = "FrmRecorte";
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLiangBarsky;
        private System.Windows.Forms.Button btnNLN;
        private System.Windows.Forms.Label label8;
    }
}