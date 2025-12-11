namespace AlgoritmosGraficosBasicos.UI
{
    partial class FrmRecortePoligono
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecortePoligono));
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCerrarPoligono = new System.Windows.Forms.Button();
            this.btnCyrus = new System.Windows.Forms.Button();
            this.btnWeiler = new System.Windows.Forms.Button();
            this.btnSuther = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVertices = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Font = new System.Drawing.Font("Stork Delivery", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(274, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 40);
            this.label8.TabIndex = 53;
            this.label8.Text = "Algoritmos de Recorte de Polígonos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(606, 76);
            this.label6.TabIndex = 51;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btnCerrarPoligono);
            this.groupBox2.Controls.Add(this.btnCyrus);
            this.groupBox2.Controls.Add(this.btnWeiler);
            this.groupBox2.Controls.Add(this.btnSuther);
            this.groupBox2.Controls.Add(this.btnResetear);
            this.groupBox2.Location = new System.Drawing.Point(532, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 187);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Botones";
            // 
            // btnCerrarPoligono
            // 
            this.btnCerrarPoligono.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCerrarPoligono.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPoligono.Location = new System.Drawing.Point(174, 131);
            this.btnCerrarPoligono.Name = "btnCerrarPoligono";
            this.btnCerrarPoligono.Size = new System.Drawing.Size(134, 35);
            this.btnCerrarPoligono.TabIndex = 11;
            this.btnCerrarPoligono.Text = "Cerrar polígono";
            this.btnCerrarPoligono.UseVisualStyleBackColor = false;
            this.btnCerrarPoligono.Click += new System.EventHandler(this.btnCerrarPoligono_Click);
            // 
            // btnCyrus
            // 
            this.btnCyrus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCyrus.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCyrus.Location = new System.Drawing.Point(102, 76);
            this.btnCyrus.Name = "btnCyrus";
            this.btnCyrus.Size = new System.Drawing.Size(112, 49);
            this.btnCyrus.TabIndex = 10;
            this.btnCyrus.Text = " Cortar Cyrus–Beck";
            this.btnCyrus.UseVisualStyleBackColor = false;
            this.btnCyrus.Click += new System.EventHandler(this.btnCyrus_Click);
            // 
            // btnWeiler
            // 
            this.btnWeiler.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWeiler.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeiler.Location = new System.Drawing.Point(196, 21);
            this.btnWeiler.Name = "btnWeiler";
            this.btnWeiler.Size = new System.Drawing.Size(112, 49);
            this.btnWeiler.TabIndex = 9;
            this.btnWeiler.Text = " Cortar Weiler";
            this.btnWeiler.UseVisualStyleBackColor = false;
            this.btnWeiler.Click += new System.EventHandler(this.btnWeiler_Click);
            // 
            // btnSuther
            // 
            this.btnSuther.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSuther.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuther.Location = new System.Drawing.Point(6, 21);
            this.btnSuther.Name = "btnSuther";
            this.btnSuther.Size = new System.Drawing.Size(112, 49);
            this.btnSuther.TabIndex = 8;
            this.btnSuther.Text = " Cortar Sutherland";
            this.btnSuther.UseVisualStyleBackColor = false;
            this.btnSuther.Click += new System.EventHandler(this.btnSuther_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnResetear.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.Location = new System.Drawing.Point(36, 131);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(112, 35);
            this.btnResetear.TabIndex = 6;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.picCanvas);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox3.Location = new System.Drawing.Point(63, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 392);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.LightBlue;
            this.picCanvas.Location = new System.Drawing.Point(41, 50);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(329, 313);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vértices:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // txtVertices
            // 
            this.txtVertices.Location = new System.Drawing.Point(94, 27);
            this.txtVertices.Multiline = true;
            this.txtVertices.Name = "txtVertices";
            this.txtVertices.ReadOnly = true;
            this.txtVertices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVertices.Size = new System.Drawing.Size(192, 63);
            this.txtVertices.TabIndex = 1;
            this.txtVertices.Text = "\r\n\r\n\r\n\r\n";
            this.txtVertices.WordWrap = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(94, 96);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(192, 22);
            this.txtEstado.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtVertices);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(532, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 133);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmRecortePoligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 603);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmRecortePoligono";
            this.Text = "FrmRellenoPoligono";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCyrus;
        private System.Windows.Forms.Button btnWeiler;
        private System.Windows.Forms.Button btnSuther;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnCerrarPoligono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVertices;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}