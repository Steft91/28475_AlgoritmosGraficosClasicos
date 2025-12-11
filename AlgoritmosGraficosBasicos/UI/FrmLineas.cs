using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmosGraficosBasicos.Algoritmos;
using AlgoritmosGraficosBasicos.Utils;

namespace AlgoritmosGraficosBasicos.UI
{
    public partial class FrmLineas : Form
    {
        public FrmLineas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(900, 600);
            this.MinimumSize = new Size(900, 600);
            this.MaximumSize = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private async Task DibujarLinea(List<Punto> puntos, Brush pincel)
        {
            int escala = 20;
            int offsetX = 50;
            int offsetY = 50;
            Color fondo = Color.Honeydew;

            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(fondo);

                Pen gridPen = new Pen(Color.FromArgb(60, Color.Black), 1);

                for (int x = offsetX; x < bmp.Width; x += escala)
                    g.DrawLine(gridPen, x, 0, x, bmp.Height);

                for (int y = bmp.Height - offsetY; y > 0; y -= escala)
                    g.DrawLine(gridPen, 0, y, bmp.Width, y);

                // === Ejes ===
                int origenX = offsetX;
                int origenY = bmp.Height - offsetY;
                g.DrawLine(Pens.Black, origenX, 0, origenX, bmp.Height);
                g.DrawLine(Pens.Black, 0, origenY, bmp.Width, origenY);

                // === Coordenadas ===
                Font font = new Font("Consolas", 8);
                Brush brush = Brushes.Black;

                for (int x = 0; x < (bmp.Width - offsetX) / escala; x++)
                    g.DrawString(x.ToString(), font, brush,
                                 origenX + x * escala - 3, origenY + 3);
               
                for (int y = 1; y <= origenY / escala; y++)
                    g.DrawString(y.ToString(), font, brush,
                                 origenX - 18, origenY - y * escala - 5);

                picCanvas.Image = bmp;
            }

            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (var p in puntos)
                {
                    int x = p.X * escala + offsetX;
                    int y = bmp.Height - (p.Y * escala + offsetY);

                    g.FillRectangle(pincel, x, y, escala - 2, escala - 2);
                    picCanvas.Image = (Bitmap)bmp.Clone();
                    await Task.Delay(40); // velocidad
                }
            }
        }

        private bool ValidarLineas(out Punto inicio, out Punto fin)
        {
            inicio = null;
            fin = null;

            if (string.IsNullOrWhiteSpace(txtX1.Text) ||
                string.IsNullOrWhiteSpace(txtY1.Text) ||
                string.IsNullOrWhiteSpace(txtX2.Text) ||
                string.IsNullOrWhiteSpace(txtY2.Text))
            {
                MessageBox.Show("Completa todas las coordenadas.", "Error");
                return false;
            }

            if (!int.TryParse(txtX1.Text, out int x1) ||
                !int.TryParse(txtY1.Text, out int y1) ||
                !int.TryParse(txtX2.Text, out int x2) ||
                !int.TryParse(txtY2.Text, out int y2))
            {
                MessageBox.Show("Debe ingresar números enteros.", "Error");
                return false;
            }

            if (x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0)
            {
                MessageBox.Show("Solo valores positivos.", "Error");
                return false;
            }
            
            //punto inicial y punto final no pueden ser iguales
            if (x1 == x2 || y1 == y2)
            {
                MessageBox.Show("El punto inicial y final no pueden ser iguales.", "Error");
                return false;
            }

            inicio = new Punto(x1, y1);
            fin = new Punto(x2, y2);
            return true;

            
        }

        private void SetButtonsEnabled(bool state)
        {
            btnBresenham.Enabled = state;
            btnDDA.Enabled = state;
            btnMedio.Enabled = state;
        }

        private async void btnDDA_Click(object sender, EventArgs e)
        {
            if (!ValidarLineas(out Punto inicio, out Punto fin)) return;
            SetButtonsEnabled(false);

            var algoritmo = new AlgoritmoDDA();
            await DibujarLinea(algoritmo.CalcularLinea(inicio, fin), Brushes.Blue);

            SetButtonsEnabled(true);
        }

        private async void btnMedio_Click(object sender, EventArgs e)
        {
            if (!ValidarLineas(out Punto inicio, out Punto fin)) return;
            SetButtonsEnabled(false);

            var algoritmo = new AlgoritmoPuntoMedio();
            await DibujarLinea(algoritmo.CalcularLinea(inicio, fin), Brushes.Green);

            SetButtonsEnabled(true);
        }

        private async void btnBresenham_Click(object sender, EventArgs e)
        {
            if (!ValidarLineas(out Punto inicio, out Punto fin)) return;
            SetButtonsEnabled(false);

            var algoritmo = new AlgoritmoBresenham();
            await DibujarLinea(algoritmo.CalcularLinea(inicio, fin), Brushes.Red);

            SetButtonsEnabled(true);
        }


    }
}
