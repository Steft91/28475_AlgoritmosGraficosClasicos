namespace AlgoritmosGraficosBasicos.UI
{
    partial class FrmRelleno
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
            this.btnInundacion = new System.Windows.Forms.Button();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.dtaPixeles = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapas = new System.Windows.Forms.Button();
            this.btnScanline = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaPixeles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInundacion
            // 
            this.btnInundacion.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInundacion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInundacion.Location = new System.Drawing.Point(252, 184);
            this.btnInundacion.Name = "btnInundacion";
            this.btnInundacion.Size = new System.Drawing.Size(144, 52);
            this.btnInundacion.TabIndex = 31;
            this.btnInundacion.Text = "Rellenar con Inundación";
            this.btnInundacion.UseVisualStyleBackColor = false;
            this.btnInundacion.Click += new System.EventHandler(this.btnInundacion_Click);
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(72, 200);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(117, 22);
            this.txtLado.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Número de lados";
            // 
            // picCanvas
            // 
            this.picCanvas.AccessibleName = "Dibujo";
            this.picCanvas.BackColor = System.Drawing.Color.PeachPuff;
            this.picCanvas.Location = new System.Drawing.Point(49, 297);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(829, 431);
            this.picCanvas.TabIndex = 24;
            this.picCanvas.TabStop = false;
            this.picCanvas.Tag = "Dibujo";
            // 
            // dtaPixeles
            // 
            this.dtaPixeles.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dtaPixeles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaPixeles.Location = new System.Drawing.Point(567, 64);
            this.dtaPixeles.Name = "dtaPixeles";
            this.dtaPixeles.RowHeadersWidth = 51;
            this.dtaPixeles.RowTemplate.Height = 24;
            this.dtaPixeles.Size = new System.Drawing.Size(311, 153);
            this.dtaPixeles.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 36;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 38);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ingrese solo un valor positivo para graficar un polígono y \r\nelija el algoritmo d" +
    "e relleno\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapas
            // 
            this.btnCapas.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCapas.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapas.Location = new System.Drawing.Point(402, 126);
            this.btnCapas.Name = "btnCapas";
            this.btnCapas.Size = new System.Drawing.Size(144, 52);
            this.btnCapas.TabIndex = 37;
            this.btnCapas.Text = "Rellenar por Capas";
            this.btnCapas.UseVisualStyleBackColor = false;
            this.btnCapas.Click += new System.EventHandler(this.btnCapas_Click);
            // 
            // btnScanline
            // 
            this.btnScanline.BackColor = System.Drawing.Color.PeachPuff;
            this.btnScanline.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanline.Location = new System.Drawing.Point(402, 184);
            this.btnScanline.Name = "btnScanline";
            this.btnScanline.Size = new System.Drawing.Size(144, 52);
            this.btnScanline.TabIndex = 38;
            this.btnScanline.Text = "Rellenar con Scanline";
            this.btnScanline.UseVisualStyleBackColor = false;
            this.btnScanline.Click += new System.EventHandler(this.btnScanline_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDibujar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(252, 126);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(144, 52);
            this.btnDibujar.TabIndex = 39;
            this.btnDibujar.Text = "Dibujar Polígono";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnReiniciar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(267, 242);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(102, 37);
            this.btnReiniciar.TabIndex = 40;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDetener.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(424, 242);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(102, 37);
            this.btnDetener.TabIndex = 41;
            this.btnDetener.Text = "Pausar";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(567, 242);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.ReadOnly = true;
            this.lblEstado.Size = new System.Drawing.Size(311, 22);
            this.lblEstado.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Stork Delivery", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(150, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 43;
            this.label1.Text = "Algoritmos de Relleno";
            // 
            // FrmRelleno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnScanline);
            this.Controls.Add(this.btnCapas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtaPixeles);
            this.Controls.Add(this.btnInundacion);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmRelleno";
            this.Text = "FrmRelleno";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaPixeles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInundacion;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.DataGridView dtaPixeles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCapas;
        private System.Windows.Forms.Button btnScanline;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.TextBox lblEstado;
        private System.Windows.Forms.Label label1;
    }
}