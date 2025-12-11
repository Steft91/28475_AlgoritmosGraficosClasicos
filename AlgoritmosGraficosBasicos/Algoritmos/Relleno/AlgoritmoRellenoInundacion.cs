using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoRellenoInundacion
    {
        public int contador = 0;

        public async Task RellenarDFS(Bitmap bmp, int x, int y,
                                  Color objetivo, Color nuevo,
                                  PictureBox canvas, DataGridView tabla,
                                  CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            if (x < 0 || y < 0 || x >= bmp.Width || y >= bmp.Height)
                return;

            Color actual = bmp.GetPixel(x, y);

            // Si no es color objetivo o ya está rellenado → detener
            if (actual.ToArgb() != objetivo.ToArgb())
                return;

            // 🔹 Marcar ya visitado cambiando color
            bmp.SetPixel(x, y, nuevo);
            tabla.Rows.Add(x, y, tabla.Rows.Count + 1);

            canvas.Image = bmp;
            canvas.Refresh();
            await Task.Delay(20);

            // 🔹 DFS en las 4 direcciones
            await RellenarDFS(bmp, x, y - 1, objetivo, nuevo, canvas, tabla, token); // N
            await RellenarDFS(bmp, x + 1, y, objetivo, nuevo, canvas, tabla, token); // E
            await RellenarDFS(bmp, x, y + 1, objetivo, nuevo, canvas, tabla, token); // S
            await RellenarDFS(bmp, x - 1, y, objetivo, nuevo, canvas, tabla, token); // O
        }
    }
}
