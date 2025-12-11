using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoRellenoBFS
    {
        public int contador = 0;

        public async Task RellenarBFS(Bitmap bmp, int x, int y,
                                      Color objetivo, Color nuevo,
                                      PictureBox canvas, DataGridView tabla,
                                      CancellationToken token)
        {
            if (objetivo.ToArgb() == nuevo.ToArgb())
                return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(new Point(x, y));

            while (cola.Count > 0)
            {
                token.ThrowIfCancellationRequested();
                Point p = cola.Dequeue();

                if (p.X < 0 || p.Y < 0 || p.X >= bmp.Width || p.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(p.X, p.Y).ToArgb() != objetivo.ToArgb())
                    continue;

                bmp.SetPixel(p.X, p.Y, nuevo);
                contador++;

                tabla.Rows.Add(p.X, p.Y, contador);

                canvas.Image = bmp;
                canvas.Refresh();
                await Task.Delay(15);

                // Expansión en 4 direcciones
                cola.Enqueue(new Point(p.X + 1, p.Y)); // E
                cola.Enqueue(new Point(p.X - 1, p.Y)); // O
                cola.Enqueue(new Point(p.X, p.Y + 1)); // S
                cola.Enqueue(new Point(p.X, p.Y - 1)); // N
            }
        }
    }
}
