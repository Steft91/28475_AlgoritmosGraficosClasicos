namespace AlgoritmosGraficosBasicos.UI
{
    partial class FrmCircunferencia
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
            this.btnPuntoMedio = new System.Windows.Forms.Button();
            this.txtCentroY = new System.Windows.Forms.TextBox();
            this.txtCentroX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParam = new System.Windows.Forms.Button();
            this.btnDDA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPuntoMedio
            // 
            this.btnPuntoMedio.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnPuntoMedio.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnPuntoMedio.Location = new System.Drawing.Point(446, 175);
            this.btnPuntoMedio.Name = "btnPuntoMedio";
            this.btnPuntoMedio.Size = new System.Drawing.Size(125, 57);
            this.btnPuntoMedio.TabIndex = 19;
            this.btnPuntoMedio.Text = "Dibujar con Punto Medio";
            this.btnPuntoMedio.UseVisualStyleBackColor = false;
            this.btnPuntoMedio.Click += new System.EventHandler(this.btnPuntoMedio_Click);
            // 
            // txtCentroY
            // 
            this.txtCentroY.Location = new System.Drawing.Point(187, 209);
            this.txtCentroY.Name = "txtCentroY";
            this.txtCentroY.Size = new System.Drawing.Size(100, 22);
            this.txtCentroY.TabIndex = 18;
            this.txtCentroY.Text = "5";
            // 
            // txtCentroX
            // 
            this.txtCentroX.Location = new System.Drawing.Point(187, 174);
            this.txtCentroX.Name = "txtCentroX";
            this.txtCentroX.Size = new System.Drawing.Size(100, 22);
            this.txtCentroX.TabIndex = 16;
            this.txtCentroX.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Centro en Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Centro en X";
            // 
            // picCanvas
            // 
            this.picCanvas.AccessibleName = "Dibujo";
            this.picCanvas.BackColor = System.Drawing.Color.LemonChiffon;
            this.picCanvas.Location = new System.Drawing.Point(43, 258);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(836, 463);
            this.picCanvas.TabIndex = 12;
            this.picCanvas.TabStop = false;
            this.picCanvas.Tag = "Dibujo";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(322, 210);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 21;
            this.txtRadio.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Radio";
            // 
            // btnParam
            // 
            this.btnParam.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnParam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnParam.Location = new System.Drawing.Point(754, 179);
            this.btnParam.Name = "btnParam";
            this.btnParam.Size = new System.Drawing.Size(125, 53);
            this.btnParam.TabIndex = 22;
            this.btnParam.Text = "Dibujar con Paramétrico";
            this.btnParam.UseVisualStyleBackColor = false;
            this.btnParam.Click += new System.EventHandler(this.btnParam_Click);
            // 
            // btnDDA
            // 
            this.btnDDA.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDDA.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnDDA.Location = new System.Drawing.Point(610, 177);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(125, 55);
            this.btnDDA.TabIndex = 23;
            this.btnDDA.Text = "Dibujar con DDA";
            this.btnDDA.UseVisualStyleBackColor = false;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 30;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(716, 38);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ingrese solo valores positivos (puesto que se dibujan en el primer cuadrante del " +
    "plano) y elija el \r\nalgoritmo para trazar una línea";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Font = new System.Drawing.Font("Stork Delivery", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(315, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 40);
            this.label7.TabIndex = 44;
            this.label7.Text = "Algoritmos de Circunferencias";
            // 
            // FrmCircunferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 753);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDDA);
            this.Controls.Add(this.btnParam);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPuntoMedio);
            this.Controls.Add(this.txtCentroY);
            this.Controls.Add(this.txtCentroX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmCircunferencia";
            this.Text = "FrmCircunferencia";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPuntoMedio;
        private System.Windows.Forms.TextBox txtCentroY;
        private System.Windows.Forms.TextBox txtCentroX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParam;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}