using System;
using System.Collections.Generic;
using AlgoritmosGraficosBasicos.Utils;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoPuntoMedio
    {
        public List<Punto> CalcularLinea(Punto inicio, Punto fin)
        {
            List<Punto> puntos = new List<Punto>();

            int x0 = inicio.X;
            int y0 = inicio.Y;
            int x1 = fin.X;
            int y1 = fin.Y;

            int dx = x1 - x0;
            int dy = y1 - y0;

            int absDx = Math.Abs(dx);
            int absDy = Math.Abs(dy);

            int sx = dx >= 0 ? 1 : -1;
            int sy = dy >= 0 ? 1 : -1;

            int x = x0;
            int y = y0;
            puntos.Add(new Punto(x, y));

            if (absDx >= absDy)
            {
                // Pendiente entre -1 y 1
                int p = 2 * absDy - absDx;

                for (int i = 0; i < absDx; i++)
                {
                    if (p < 0)
                    {
                        p += 2 * absDy;
                        x += sx;
                    }
                    else
                    {
                        p += 2 * (absDy - absDx);
                        x += sx;
                        y += sy;
                    }
                    puntos.Add(new Punto(x, y));
                }
            }
            else
            {
                // Pendiente mayor a 1 o menor a -1
                int p = 2 * absDx - absDy;

                for (int i = 0; i < absDy; i++)
                {
                    if (p < 0)
                    {
                        p += 2 * absDx;
                        y += sy;
                    }
                    else
                    {
                        p += 2 * (absDx - absDy);
                        x += sx;
                        y += sy;
                    }
                    puntos.Add(new Punto(x, y));
                }
            }

            return puntos;
        }
    }
}
