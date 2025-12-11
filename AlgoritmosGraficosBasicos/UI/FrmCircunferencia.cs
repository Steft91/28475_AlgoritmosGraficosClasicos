using AlgoritmosGraficosBasicos.Algoritmos;
using AlgoritmosGraficosBasicos.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.UI
{
    public partial class FrmCircunferencia : Form
    {
        public FrmCircunferencia()
        {
            InitializeComponent();
        }

        private async Task DibujarCircunferencia(List<Punto> puntos, Brush pincel)
        {
            int escala = 20;
            int offsetX = 50;
            int offsetY = 50;
            Color fondo = Color.LemonChiffon;

            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(fondo);

                Pen gridPen = new Pen(Color.FromArgb(60, Color.Black), 1);

                for (int x = offsetX; x < bmp.Width; x += escala)
                    g.DrawLine(gridPen, x, 0, x, bmp.Height);

                for (int x = offsetX; x > 0; x -= escala)
                    g.DrawLine(gridPen, x, 0, x, bmp.Height);

                for (int y = bmp.Height - offsetY; y < bmp.Height; y += escala)
                    g.DrawLine(gridPen, 0, y, bmp.Width, y);

                for (int y = bmp.Height - offsetY; y > 0; y -= escala)
                    g.DrawLine(gridPen, 0, y, bmp.Width, y);


                // === Coordenadas del origen ===
                int origenX = offsetX;
                int origenY = bmp.Height - offsetY;

                Font font = new Font("Consolas", 8);
                Brush brush = Brushes.Black;


                int maxPosX = (bmp.Width - origenX) / escala;
                int maxNegX = origenX / escala;

                for (int i = -maxNegX; i <= maxPosX; i++)
                {
                    int pixelX = origenX + i * escala;
                    if (pixelX < 0 || pixelX >= bmp.Width) continue;

                    string txt = i.ToString();
                    SizeF size = g.MeasureString(txt, font);

                    // Etiqueta centrada en la celda, un poquito debajo del eje X
                    float tx = pixelX - size.Width / 2;
                    float ty = origenY + 2;

                    g.DrawString(txt, font, brush, tx, ty);
                }

                int maxPosY = origenY / escala;
                int maxNegY = (bmp.Height - origenY) / escala;

                for (int j = -maxNegY; j <= maxPosY; j++)
                {
                    if (j == 0) continue; // evitar dibujar otro 0 aquí

                    int pixelY = origenY - j * escala;
                    if (pixelY < 0 || pixelY >= bmp.Height) continue;

                    string txt = j.ToString();
                    SizeF size = g.MeasureString(txt, font);

                    // Etiqueta a la izquierda del eje Y, centrada verticalmente en la celda
                    float tx = origenX - size.Width - 4;
                    float ty = pixelY - size.Height / 2;

                    g.DrawString(txt, font, brush, tx, ty);
                }



            }

            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (var punto in puntos)
                {
                    int x = punto.X * escala + offsetX;
                    int y = bmp.Height - (punto.Y * escala + offsetY);

                    g.FillRectangle(pincel, x, y, escala - 2, escala - 2);
                    picCanvas.Image = (Bitmap)bmp.Clone();
                    await Task.Delay(8);
                }
            }
        }

        private void SetButtonsEnabled(bool enabled)
        {
            btnPuntoMedio.Enabled = enabled;
            btnDDA.Enabled = enabled;
            btnParam.Enabled = enabled;
        }



        private async void btnPuntoMedio_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtCentroX.Text) ||
                string.IsNullOrWhiteSpace(txtCentroY.Text) ||
                string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Por favor ingresa todos los valores: Centro (X, Y) y Radio.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validación de números
            if (!int.TryParse(txtCentroX.Text, out int cx) ||
                !int.TryParse(txtCentroY.Text, out int cy) ||
                !int.TryParse(txtRadio.Text, out int radio))
            {
                MessageBox.Show("Solo se permiten valores numéricos enteros.",
                                "Valores inválidos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validación área válida (primer cuadrante)
            if (cx < 0 || cy < 0 || radio <= 0)
            {
                MessageBox.Show("X, Y deben ser ≥ 0 y el Radio mayor a 0.",
                                "Valores fuera de rango",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }



            SetButtonsEnabled(false);
            Punto centro = new Punto(cx, cy);
            var algoritmo = new AlgoritmoCircunferenciaPM();

            var puntos = algoritmo.CalcularCircunferencia(centro, radio);
            await DibujarCircunferencia(puntos, Brushes.Lavender);

            SetButtonsEnabled(true);
        }

        private async void btnDDA_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtCentroX.Text) ||
                string.IsNullOrWhiteSpace(txtCentroY.Text) ||
                string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Por favor ingresa todos los valores: Centro (X, Y) y Radio.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validación de números
            if (!int.TryParse(txtCentroX.Text, out int cx) ||
                !int.TryParse(txtCentroY.Text, out int cy) ||
                !int.TryParse(txtRadio.Text, out int radio))
            {
                MessageBox.Show("Solo se permiten valores numéricos enteros.",
                                "Valores inválidos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validación área válida (primer cuadrante)
            if (cx < 0 || cy < 0 || radio <= 0)
            {
                MessageBox.Show("X, Y deben ser ≥ 0 y el Radio mayor a 0.",
                                "Valores fuera de rango",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            SetButtonsEnabled(false);
            Punto centro = new Punto(cx, cy);
            var algoritmo = new AlgoritmoCircunferenciaDDA();
            var puntos = algoritmo.CalcularCircunferencia(centro, radio);
            await DibujarCircunferencia(puntos, Brushes.LightCoral);

            SetButtonsEnabled(true);
        }

        private async void btnParam_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtCentroX.Text) ||
                string.IsNullOrWhiteSpace(txtCentroY.Text) ||
                string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Por favor ingresa todos los valores: Centro (X, Y) y Radio.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validación de números
            if (!int.TryParse(txtCentroX.Text, out int cx) ||
                !int.TryParse(txtCentroY.Text, out int cy) ||
                !int.TryParse(txtRadio.Text, out int radio))
            {
                MessageBox.Show("Solo se permiten valores numéricos enteros.",
                                "Valores inválidos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validación área válida (primer cuadrante)
            if (cx < 0 || cy < 0 || radio <= 0)
            {
                MessageBox.Show("X, Y deben ser ≥ 0 y el Radio mayor a 0.",
                                "Valores fuera de rango",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }



            SetButtonsEnabled(false);
            Punto centro = new Punto(cx, cy);
            var algoritmo = new AlgoritmoCircunferenciaParametrica();
            var puntos = algoritmo.CalcularCircunferencia(centro, radio);
            await DibujarCircunferencia(puntos, Brushes.Olive);

            SetButtonsEnabled(true);
        }
    }
}
