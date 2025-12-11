using AlgoritmosGraficosBasicos.Algoritmos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.UI
{
    public partial class FrmRecortePoligono : Form
    {
        private List<PointF> polygon = new List<PointF>();
        private bool polygonClosed = false;
        private string metodo = "";
        private RectangleF clipWindow = new RectangleF(83, 83, 83, 83);

        public FrmRecortePoligono()
        {
            InitializeComponent();
            picCanvas.MouseClick += picCanvas_MouseClick;
            picCanvas.Paint += picCanvas_Paint;
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (polygonClosed)
                return;

            polygon.Add(new PointF(e.X, e.Y));
            ActualizarVertices();
            Estado("Punto agregado");
            picCanvas.Invalidate();

        }

        private void btnCerrarPoligono_Click(object sender, EventArgs e)
        {
            if (polygon.Count < 3)
            {
                MessageBox.Show("Debe tener al menos 3 puntos para cerrar el polígono.");
                return;
            }

            polygonClosed = true;
            ActualizarVertices();
            Estado("Polígono cerrado");
            picCanvas.Invalidate();

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            polygon.Clear();
            polygonClosed = false;
            metodo = "";
            picCanvas.Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuther_Click(object sender, EventArgs e)
        {
            metodo = "SUTHERLAND";
            AplicarRecorte();
        }

        private void btnWeiler_Click(object sender, EventArgs e)
        {
            metodo = "WEILER";
            AplicarRecorte();
        }

        private void btnCyrus_Click(object sender, EventArgs e)
        {
            metodo = "CYRUS";
            AplicarRecorte();
        }

        private void AplicarRecorte()
        {
            if (!polygonClosed)
            {
                Estado("Primero cierre el polígono");
                return;
            }

            if (polygon.Count < 3)
            {
                Estado("Se necesitan mínimo 3 vértices");
                return;
            }

            List<PointF> resultado = null;

            try
            {
                switch (metodo)
                {
                    case "SUTHERLAND":
                        var suth = new AlgoritmoSutherlandHodgman();
                        resultado = suth.ClipPolygon(polygon);
                        Estado("Recorte Sutherland-Hodgman completado");
                        break;

                    case "WEILER":
                        var wei = new AlgoritmoWeilerAtherton();
                        resultado = wei.ClipPolygon(polygon);
                        Estado("Recorte Weiler-Atherton completado");
                        break;

                    case "CYRUS":
                        var cyrus = new AlgoritmoCyrusBeck();
                        resultado = cyrus.ClipPolygon(polygon);
                        Estado("Recorte Cyrus-Beck completado");
                        break;

                    default:
                        Estado("Seleccione un método de recorte");
                        return;
                }

                if (resultado == null || resultado.Count == 0)
                {
                    Estado("El polígono quedó completamente fuera de la ventana");
                    polygon.Clear();
                    polygonClosed = false;
                    txtVertices.Clear();
                    picCanvas.Invalidate();
                    return;
                }

                // Actualizar el polígono con el resultado
                polygon = resultado;
                polygonClosed = true;

                // Actualizar textbox de vértices
                ActualizarVertices();

                // Redibujar
                picCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                Estado("Error: " + ex.Message);
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibujar ventana de recorte
            using (Pen p = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(p, clipWindow.X, clipWindow.Y, clipWindow.Width, clipWindow.Height);
            }

            // Dibujar polígono original o recortado
            if (polygon.Count > 1)
            {
                using (Pen polyPen = new Pen(polygonClosed ? Color.Blue : Color.Red, 2))
                {
                    g.DrawLines(polyPen, polygon.ToArray());

                    if (polygonClosed)
                        g.DrawLine(polyPen, polygon[polygon.Count - 1], polygon[0]);
                }
            }

            // Dibujar puntos
            foreach (var p in polygon)
            {
                g.FillEllipse(Brushes.DarkGreen, p.X - 3, p.Y - 3, 6, 6);
            }
        }

        private void ActualizarVertices()
        {
            txtVertices.Clear();
            int i = 1;

            foreach (PointF p in polygon)
            {
                txtVertices.AppendText($"V{i}: ({p.X:F0}, {p.Y:F0}){Environment.NewLine}");
                i++;
            }
        }



        private void Estado(string msg)
        {
            txtEstado.Text = msg;
        }

    }
}

