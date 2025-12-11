using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.Graficos
{
    internal class PixelAnimator
    {
        public async Task RellenarLineaPorLinea(Bitmap bmp, int x, int y, Color colorObjetivo, Color colorRelleno, PictureBox canvas, DataGridView grid)
        {
            if (colorObjetivo.ToArgb() == colorRelleno.ToArgb())
                return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(new Point(x, y));

            while (cola.Count > 0)
            {
                Point punto = cola.Dequeue();
                int px = punto.X;
                int py = punto.Y;

                while (px >= 0 && bmp.GetPixel(px, py).ToArgb() == colorObjetivo.ToArgb())
                    px--;
                px++;

                bool arriba = false, abajo = false;

                while (px < bmp.Width && bmp.GetPixel(px, py).ToArgb() == colorObjetivo.ToArgb())
                {
                    bmp.SetPixel(px, py, colorRelleno);
                    canvas.Refresh();

                    //Tabla
                    if (grid.InvokeRequired)
                    {
                        grid.Invoke((MethodInvoker)(() =>
                        {
                            grid.Rows.Add(px, py);
                        }));
                    }
                    else
                    {
                        grid.Rows.Add(px, py);
                    }

                    //PixelArriba
                    if (py > 0 && bmp.GetPixel(px, py - 1).ToArgb() == colorObjetivo.ToArgb())
                    {
                        if (!arriba)
                        {
                            cola.Enqueue(new Point(px, py - 1));
                            arriba = true;
                        }
                    }
                    else
                    {
                        arriba = false;
                    }

                    //PixelesAbajo
                    if (py < bmp.Height - 1 && bmp.GetPixel(px, py + 1).ToArgb() == colorObjetivo.ToArgb())
                    {
                        if (!abajo)
                        {
                            cola.Enqueue(new Point(px, py + 1));
                            abajo = true;
                        }
                    }
                    else
                    {
                        abajo = false;
                    }

                    px++;
                    await Task.Delay(5); 
                }
            }
        }
    }
}
