namespace AlgoritmosGraficosBasicos
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trazadoDeCírculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porInundaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFPorFronteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteDePolígonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.trazadoDeCírculosToolStripMenuItem,
            this.rellenoToolStripMenuItem,
            this.recorteToolStripMenuItem,
            this.recorteDePolígonosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.algoritmosToolStripMenuItem.Text = "Trazado de líneas";
            this.algoritmosToolStripMenuItem.Click += new System.EventHandler(this.algoritmosToolStripMenuItem_Click);
            // 
            // trazadoDeCírculosToolStripMenuItem
            // 
            this.trazadoDeCírculosToolStripMenuItem.Name = "trazadoDeCírculosToolStripMenuItem";
            this.trazadoDeCírculosToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.trazadoDeCírculosToolStripMenuItem.Text = "Trazado de Círculos";
            this.trazadoDeCírculosToolStripMenuItem.Click += new System.EventHandler(this.trazadoDeCírculosToolStripMenuItem_Click);
            // 
            // rellenoToolStripMenuItem
            // 
            this.rellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porInundaciónToolStripMenuItem,
            this.bFSToolStripMenuItem,
            this.bFPorFronteraToolStripMenuItem});
            this.rellenoToolStripMenuItem.Name = "rellenoToolStripMenuItem";
            this.rellenoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.rellenoToolStripMenuItem.Text = "Relleno";
            this.rellenoToolStripMenuItem.Click += new System.EventHandler(this.rellenoToolStripMenuItem_Click);
            // 
            // porInundaciónToolStripMenuItem
            // 
            this.porInundaciónToolStripMenuItem.Name = "porInundaciónToolStripMenuItem";
            this.porInundaciónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porInundaciónToolStripMenuItem.Text = "DFS: Por inundación";
            // 
            // bFSToolStripMenuItem
            // 
            this.bFSToolStripMenuItem.Name = "bFSToolStripMenuItem";
            this.bFSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bFSToolStripMenuItem.Text = "BFS: Por capas";
            // 
            // bFPorFronteraToolStripMenuItem
            // 
            this.bFPorFronteraToolStripMenuItem.Name = "bFPorFronteraToolStripMenuItem";
            this.bFPorFronteraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bFPorFronteraToolStripMenuItem.Text = "BF: Por frontera";
            // 
            // recorteToolStripMenuItem
            // 
            this.recorteToolStripMenuItem.AutoSize = false;
            this.recorteToolStripMenuItem.Name = "recorteToolStripMenuItem";
            this.recorteToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.recorteToolStripMenuItem.Text = "Recorte de líneas";
            this.recorteToolStripMenuItem.Click += new System.EventHandler(this.recorteToolStripMenuItem_Click);
            // 
            // recorteDePolígonosToolStripMenuItem
            // 
            this.recorteDePolígonosToolStripMenuItem.Name = "recorteDePolígonosToolStripMenuItem";
            this.recorteDePolígonosToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.recorteDePolígonosToolStripMenuItem.Text = "Recorte de polígonos";
            this.recorteDePolígonosToolStripMenuItem.Click += new System.EventHandler(this.recorteDePolígonosToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(912, 853);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porInundaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFPorFronteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trazadoDeCírculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteDePolígonosToolStripMenuItem;
    }
}