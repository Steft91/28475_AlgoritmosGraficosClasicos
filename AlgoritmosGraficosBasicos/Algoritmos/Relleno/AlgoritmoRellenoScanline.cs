using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoRellenoScanline
    {
        public async Task RellenarScanline(Bitmap bmp, int x, int y,
                                           Color colorObjetivo, Color colorRelleno,
                                           PictureBox canvas,
                                           DataGridView tabla, CancellationToken token)
        {
            if (colorObjetivo.ToArgb() == colorRelleno.ToArgb())
                return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(new Point(x, y));

            while (cola.Count > 0)
            {
                token.ThrowIfCancellationRequested();

                Point p = cola.Dequeue();
                int px = p.X;
                int py = p.Y;

                if (px < 0 || px >= bmp.Width || py < 0 || py >= bmp.Height)
                    continue;

                // Saltar si NO pertenece al área original
                if (bmp.GetPixel(px, py).ToArgb() != colorObjetivo.ToArgb())
                    continue;

                // Expandir hacia la izquierda
                int xLeft = px;
                while (xLeft >= 0 && bmp.GetPixel(xLeft, py).ToArgb() == colorObjetivo.ToArgb())
                {
                    bmp.SetPixel(xLeft, py, colorRelleno);
                    tabla.Rows.Add(xLeft, py, tabla.Rows.Count + 1);
                    xLeft--;
                }

                // Expandir hacia la derecha
                int xRight = px + 1;
                while (xRight < bmp.Width && bmp.GetPixel(xRight, py).ToArgb() == colorObjetivo.ToArgb())
                {
                    bmp.SetPixel(xRight, py, colorRelleno);
                    tabla.Rows.Add(xRight, py, tabla.Rows.Count + 1);
                    xRight++;
                }

                // Refrescar animación
                canvas.Image = bmp;
                canvas.Refresh();
                await Task.Delay(10);

                // Agregar vecinos (arriba y abajo) entre Left y Right
                for (int i = xLeft + 1; i < xRight; i++)
                {
                    if (py > 0 && bmp.GetPixel(i, py - 1).ToArgb() == colorObjetivo.ToArgb())
                        cola.Enqueue(new Point(i, py - 1));

                    if (py < bmp.Height - 1 && bmp.GetPixel(i, py + 1).ToArgb() == colorObjetivo.ToArgb())
                        cola.Enqueue(new Point(i, py + 1));
                }
            }
        }
    }
}
  