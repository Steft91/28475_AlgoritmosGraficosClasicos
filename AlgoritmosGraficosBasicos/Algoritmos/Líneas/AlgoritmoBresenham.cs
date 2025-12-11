using System;
using System.Collections.Generic;
using AlgoritmosGraficosBasicos.Utils;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoBresenham
    {
        public List<Punto> CalcularLinea(Punto inicio, Punto fin)
        {
            List<Punto> puntos = new List<Punto>();

            int x0 = inicio.X;
            int y0 = inicio.Y;
            int x1 = fin.X;
            int y1 = fin.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                puntos.Add(new Punto(x0, y0));

                if (x0 == x1 && y0 == y1)
                    break;

                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }

            return puntos;
        }
    }
}
