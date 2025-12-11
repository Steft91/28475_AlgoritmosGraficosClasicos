using AlgoritmosGraficosBasicos.Algoritmos;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.UI
{
    public partial class FrmRelleno : Form
    {
        private Bitmap bmp;
        private bool poligonoDibujado = false;
        private string metodoSeleccionado = "";
        private CancellationTokenSource cancelTokenSource;

        public FrmRelleno()
        {
            InitializeComponent();
            picCanvas.MouseClick += picCanvas_MouseClick;
        }

        private void SetButtons(bool enabled)
        {
            btnDibujar.Enabled = enabled && !poligonoDibujado;
            btnInundacion.Enabled = enabled && poligonoDibujado;
            btnScanline.Enabled = enabled && poligonoDibujado;
            btnCapas.Enabled = enabled && poligonoDibujado;
            btnDetener.Enabled = !enabled;
            btnReiniciar.Enabled = enabled;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLado.Text, out int lados) || lados < 3)
            {
                MessageBox.Show("Ingresa mínimo 3 lados y que sea un número positivo.");
                return;
            }

            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);

            float cx = picCanvas.Width / 2f;
            float cy = picCanvas.Height / 2f;
            float radio = Math.Min(picCanvas.Width, picCanvas.Height) * 0.25f;

            PointF[] puntos = new PointF[lados];
            double ang = 2 * Math.PI / lados;

            for (int i = 0; i < lados; i++)
            {
                puntos[i] = new PointF(
                    cx + radio * (float)Math.Cos(i * ang - Math.PI / 2),
                    cy + radio * (float)Math.Sin(i * ang - Math.PI / 2));
            }

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.PeachPuff);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                g.DrawPolygon(new Pen(Color.Black, 2), puntos);
            }

            picCanvas.Image = bmp;
            poligonoDibujado = true;
            MetodoTexto("Selecciona un método de relleno");

            SetButtons(true);
        }

        private void MetodoTexto(string mensaje)
        {
            lblEstado.Text = mensaje;
        }

        private void btnInundacion_Click(object sender, EventArgs e)
        {
            SetButtons(false);
            metodoSeleccionado = "DFS";
            MetodoTexto("Haz clic dentro del polígono");
            SetButtons(true);
        }

        private void btnCapas_Click(object sender, EventArgs e)
        {
            SetButtons(false);
            metodoSeleccionado = "BFS";
            MetodoTexto("Haz clic dentro del polígono");
            SetButtons(true);
        }

        private void btnScanline_Click(object sender, EventArgs e)
        {
            SetButtons(false);
            metodoSeleccionado = "Scanline";
            MetodoTexto("Haz clic dentro del polígono");
            SetButtons(true);
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {


            if (!poligonoDibujado || metodoSeleccionado == "")
                return;

            cancelTokenSource = new CancellationTokenSource();
            var token = cancelTokenSource.Token;

            SetButtons(false); // Deshabilitar botones durante animación

            int x = e.X;
            int y = e.Y;

            Color objetivo = bmp.GetPixel(x, y);
            Color nuevo = Color.Red;


            dtaPixeles.Rows.Clear();
            dtaPixeles.Columns.Clear();
            dtaPixeles.Columns.Add("X", "X");
            dtaPixeles.Columns.Add("Y", "Y");
            dtaPixeles.Columns.Add("Orden", "Orden");

            try
            {
                if (metodoSeleccionado == "DFS")
                {
                    var fill = new AlgoritmoRellenoInundacion();
                    await fill.RellenarDFS(bmp, x, y, objetivo, nuevo, picCanvas, dtaPixeles, token);
                }
                else if (metodoSeleccionado == "BFS")
                {
                    var fill = new AlgoritmoRellenoBFS();
                    await fill.RellenarBFS(bmp, x, y, objetivo, nuevo, picCanvas, dtaPixeles, token);
                }
                else if (metodoSeleccionado == "Scanline")
                {
                    var fill = new AlgoritmoRellenoScanline();

                    if (objetivo.ToArgb() == Color.Black.ToArgb())
                    {
                        MessageBox.Show("Haz clic dentro del polígono, no en el borde");
                        SetButtons(true);
                        return;
                    }

                    await fill.RellenarScanline(bmp, x, y, objetivo, nuevo, picCanvas, dtaPixeles, token);
                }

            }
            catch (OperationCanceledException)
            {
                MetodoTexto("Relleno detenido ");
            }

            if (!token.IsCancellationRequested)
                MetodoTexto("Relleno completado ");

            SetButtons(true);
            metodoSeleccionado = "";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            cancelTokenSource?.Cancel();
            bmp = null;
            picCanvas.Image = null;
            dtaPixeles.Rows.Clear();
            txtLado.Clear();
            poligonoDibujado = false;
            metodoSeleccionado = "";
            MetodoTexto("Ingrese número de lados y dibuje");
            SetButtons(true);
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            cancelTokenSource?.Cancel();
            MetodoTexto("Deteniendo... espere");

        }
    }
}
