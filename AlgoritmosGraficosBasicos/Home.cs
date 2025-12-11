using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent(); 

            this.BackColor = Color.White;
            this.IsMdiContainer = true;
            //panel  debajo del MenuStrip
            Panel panelDecorativo = new Panel();
            panelDecorativo.Dock = DockStyle.Top;
            panelDecorativo.Height = 80;
            panelDecorativo.BackColor = Color.Lavender; 

            this.Controls.Add(panelDecorativo);
            panelDecorativo.BringToFront();

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = "Algoritmos para trazar líneas, discretizacion de circunferencias, relleno, recorte de líneas y polígonos";
            lblTitulo.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.ForeColor = Color.FromArgb(30, 64, 124);

            panelDecorativo.Controls.Add(lblTitulo);
  
        }

        public void OpenWindow(Form frm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }



        private void recorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWindow(new UI.FrmRecorte());
        }

        private void trazadoDeCírculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWindow(new UI.FrmCircunferencia());
        }

        private void algoritmosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWindow(new UI.FrmLineas());
        }

        private void rellenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWindow(new UI.FrmRelleno());
        }

        private void recorteDePolígonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWindow(new UI.FrmRecortePoligono());
        }


        //mistyrose - honeydew* - lavender - thistle - peachpuff - steelblue
    }
}
