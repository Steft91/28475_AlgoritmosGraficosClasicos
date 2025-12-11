using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoRecorteCohen
    {
        // Constantes para los códigos de región
        private const int INSIDE = 0;  // 0000
        private const int LEFT = 1;    // 0001
        private const int RIGHT = 2;   // 0010
        private const int BOTTOM = 4;  // 0100
        private const int TOP = 8;     // 1000

        // Límites de la ventana de recorte (cuadrante central)
        private readonly int XMin = 83;  // 250/3 ≈ 83.33
        private readonly int XMax = 166; // 2*250/3 ≈ 166.66
        private readonly int YMin = 83;  // 250/3 ≈ 83.33
        private readonly int YMax = 166; // 2*250/3 ≈ 166.66

        // Tamaño de cada cuadrante
        private readonly int QuadrantSize = 250 / 3; // ≈ 83.33

        // Método para calcular el código de región de un punto
        private int ComputeRegionCode(float x, float y)
        {
            int code = INSIDE;

            if (x < XMin) code |= LEFT;
            else if (x > XMax) code |= RIGHT;
            if (y < YMin) code |= TOP;
            else if (y > YMax) code |= BOTTOM;

            return code;
        }

        // Método para recortar la línea
        public bool ClipLine(PointF p0, PointF p1, out PointF newP0, out PointF newP1)
        {
            newP0 = p0;
            newP1 = p1;

            int code0 = ComputeRegionCode(p0.X, p0.Y);
            int code1 = ComputeRegionCode(p1.X, p1.Y); // Corregido: p1.X, p1.Y
            bool accept = false;

            while (true)
            {
                // Caso trivial de aceptación: ambos puntos dentro (0000)
                if ((code0 | code1) == 0)
                {
                    accept = true;
                    break;
                }
                // Caso trivial de rechazo: ambos puntos fuera en la misma región
                else if ((code0 & code1) != 0)
                {
                    break;
                }
                // Recorte
                else
                {
                    int codeOut = code0 != 0 ? code0 : code1;
                    float x = 0, y = 0;

                    // Calcular intersección con los bordes
                    if ((codeOut & TOP) != 0)
                    {
                        if (Math.Abs(p1.Y - p0.Y) < 0.0001) break; // Evitar división por cero
                        x = p0.X + (p1.X - p0.X) * (YMin - p0.Y) / (p1.Y - p0.Y);
                        y = YMin;
                    }
                    else if ((codeOut & BOTTOM) != 0)
                    {
                        if (Math.Abs(p1.Y - p0.Y) < 0.0001) break; // Evitar división por cero
                        x = p0.X + (p1.X - p0.X) * (YMax - p0.Y) / (p1.Y - p0.Y);
                        y = YMax;
                    }
                    else if ((codeOut & RIGHT) != 0)
                    {
                        if (Math.Abs(p1.X - p0.X) < 0.0001) break; // Evitar división por cero
                        y = p0.Y + (p1.Y - p0.Y) * (XMax - p0.X) / (p1.X - p0.X);
                        x = XMax;
                    }
                    else if ((codeOut & LEFT) != 0)
                    {
                        if (Math.Abs(p1.X - p0.X) < 0.0001) break; // Evitar división por cero
                        y = p0.Y + (p1.Y - p0.Y) * (XMin - p0.X) / (p1.X - p0.X);
                        x = XMin;
                    }

                    // Actualizar el punto que está fuera
                    if (codeOut == code0)
                    {
                        newP0 = new PointF(x, y);
                        code0 = ComputeRegionCode(newP0.X, newP0.Y);
                    }
                    else
                    {
                        newP1 = new PointF(x, y);
                        code1 = ComputeRegionCode(newP1.X, newP1.Y);
                    }
                }
            }

            return accept;
        }

        // Método para dibujar los 9 cuadrantes y sus códigos de región
        public void DrawQuadrants(Graphics g)
        {
            // Pluma gris semitransparente
            using (Pen grayPen = new Pen(Color.FromArgb(128, Color.Gray), 1))
            {
                // Dibujar líneas verticales
                g.DrawLine(grayPen, QuadrantSize, 0, QuadrantSize, 250);
                g.DrawLine(grayPen, 2 * QuadrantSize, 0, 2 * QuadrantSize, 250);

                // Dibujar líneas horizontales
                g.DrawLine(grayPen, 0, QuadrantSize, 250, QuadrantSize);
                g.DrawLine(grayPen, 0, 2 * QuadrantSize, 250, 2 * QuadrantSize);
            }

            // Fuente para etiquetas
            using (Font font = new Font("Arial", 10))
            using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Gray)))
            {
                // Códigos de región y posiciones ajustadas para centrar
                string[] codes = { "1001", "1000", "1010", "0001", "0000", "0010", "0101", "0100", "0110" };
                int[] xOffsets = { 20, 103, 186, 20, 103, 186, 20, 103, 186 };
                int[] yOffsets = { 20, 20, 20, 103, 103, 103, 186, 186, 186 };

                for (int i = 0; i < 9; i++)
                {
                    g.DrawString(codes[i], font, brush, xOffsets[i], yOffsets[i]);
                }
            }

            // Dibujar la ventana de recorte (cuadrante central) en negro
            using (Pen blackPen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(blackPen, XMin, YMin, XMax - XMin, YMax - YMin);
            }
        }
    }
}
