using AlgoritmosGraficosBasicos.Algoritmos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.UI
{
    public partial class FrmRecorte : Form
    {
        private AlgoritmoRecorteCohen clipperCohen;
        private AlgoritmoRecorteLiangBarsky clipperLiang;
        private AlgoritmoRecorteNichollLeeNicholl clipperNLN;

        private List<(PointF p0, PointF p1)> lines; // Lista de líneas dibujadas
        private PointF? startPoint; // Punto inicial para la línea actual
        private bool showClipped; // Bandera para mostrar solo líneas recortadas

        public FrmRecorte()
        {
            InitializeComponent();
            clipperCohen = new AlgoritmoRecorteCohen();
            clipperLiang = new AlgoritmoRecorteLiangBarsky();
            clipperNLN = new AlgoritmoRecorteNichollLeeNicholl();

            lines = new List<(PointF p0, PointF p1)>();
            startPoint = null;
            showClipped = false;
            picCanvas.Paint += picCanvas_Paint;
            picCanvas.BackColor = Color.White; // Fondo blanco para visibilidad
        }

        private string metodoRecorte = "Cohen";



        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // Ajustar coordenadas relativas al PictureBox dentro del groupBox3
            PointF clickPoint = new PointF(e.X, e.Y);
            Console.WriteLine($"Clic en: ({clickPoint.X}, {clickPoint.Y})");

            if (startPoint == null)
            {
                // Primer clic: punto inicial
                startPoint = clickPoint;
                txtX0.Text = clickPoint.X.ToString("F0");
                txtY0.Text = clickPoint.Y.ToString("F0");
            }
            else
            {
                // Segundo clic: punto final, agregar línea
                txtX1.Text = clickPoint.X.ToString("F0");
                txtY1.Text = clickPoint.Y.ToString("F0");
                lines.Add((startPoint.Value, clickPoint));
                Console.WriteLine($"Línea agregada: ({startPoint.Value.X}, {startPoint.Value.Y}) " +
                    $"a ({clickPoint.X}, {clickPoint.Y})");
                startPoint = null; // Reiniciar para la próxima línea
                showClipped = false; // Mostrar líneas originales
                picCanvas.Invalidate();
            }
            picCanvas.Invalidate(); // Forzar redibujado
        }

        

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Limpiar todo
            lines.Clear();
            startPoint = null;
            showClipped = false;
            txtX0.Text = "";
            txtY0.Text = "";
            txtX1.Text = "";
            txtY1.Text = "";
            Console.WriteLine("Formulario reseteado");
            picCanvas.Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // 1️⃣ Dibujar cuadrantes primero
                clipperCohen.DrawQuadrants(g);

                // 2️⃣ Luego las líneas del usuario
                if (!showClipped)
                {
                    using (Pen redPen = new Pen(Color.Red, 2))
                    {
                        foreach (var line in lines)
                            g.DrawLine(redPen, line.p0, line.p1);
                    }

                    // Dibujar punto inicial si existe
                    if (startPoint.HasValue)
                        g.FillEllipse(Brushes.Green,
                            startPoint.Value.X - 3,
                            startPoint.Value.Y - 3,
                            6, 6);
                }
                else
                {
                    using (Pen bluePen = new Pen(Color.Blue, 2))
                    {
                        foreach (var line in lines)
                        {
                            bool accept = false;
                            PointF np0 = line.p0;
                            PointF np1 = line.p1;

                            if (metodoRecorte == "Cohen")
                                accept = clipperCohen.ClipLine(line.p0, line.p1, out np0, out np1);
                            else if (metodoRecorte == "Liang")
                                accept = clipperLiang.ClipLine(line.p0, line.p1, out np0, out np1);
                            else if (metodoRecorte == "NLN")
                                accept = clipperNLN.ClipLine(line.p0, line.p1, out np0, out np1);

                            if (accept)
                                g.DrawLine(bluePen, np0, np1);
                        }
                    }
                }
            }
            catch { }
        }
        private void btnCortar_Click(object sender, EventArgs e)
        {
            metodoRecorte = "Cohen";
            showClipped = true;
            picCanvas.Invalidate();
        }
        private void btnLiangBarsky_Click(object sender, EventArgs e)
        {
            metodoRecorte = "Liang";
            showClipped = true;
            picCanvas.Invalidate();
        }

        private void btnNLN_Click(object sender, EventArgs e)
        {
            metodoRecorte = "NLN";
            showClipped = true;
            picCanvas.Invalidate();
        }
    }
}