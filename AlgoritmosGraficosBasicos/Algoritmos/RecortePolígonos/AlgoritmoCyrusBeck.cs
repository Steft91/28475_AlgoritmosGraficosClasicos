using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoCyrusBeck
    {
        private RectangleF clip;

        public AlgoritmoCyrusBeck()
        {
            clip = new RectangleF(83, 83, 83, 83);
        }

        public List<PointF> ClipPolygon(List<PointF> poly)
        {
            List<PointF> clipped = new List<PointF>();

            for (int i = 0; i < poly.Count; i++)
            {
                PointF p0 = poly[i];
                PointF p1 = poly[(i + 1) % poly.Count];

                if (ClipLineCB(p0, p1, out PointF newP0, out PointF newP1))
                {
                    clipped.Add(newP0);
                    clipped.Add(newP1);
                }
            }

            return clipped;
        }

        private bool ClipLineCB(PointF p0, PointF p1, out PointF q0, out PointF q1)
        {
            float tE = 0;  // entrar
            float tL = 1;  // salir

            float dx = p1.X - p0.X;
            float dy = p1.Y - p0.Y;

            float[] p = { -dx, dx, -dy, dy };
            float[] q = {
                p0.X - clip.Left,
                clip.Right - p0.X,
                p0.Y - clip.Top,
                clip.Bottom - p0.Y
            };

            for (int i = 0; i < 4; i++)
            {
                if (p[i] == 0)
                {
                    if (q[i] < 0)
                    {
                        q0 = p0; q1 = p1;
                        return false;
                    }
                }
                else
                {
                    float t = q[i] / p[i];

                    if (p[i] < 0)
                        tE = Math.Max(tE, t);
                    else
                        tL = Math.Min(tL, t);

                    if (tE > tL)
                    {
                        q0 = p0; q1 = p1;
                        return false;
                    }
                }
            }

            q0 = new PointF(p0.X + tE * dx, p0.Y + tE * dy);
            q1 = new PointF(p0.X + tL * dx, p0.Y + tL * dy);
            return true;
        }
    }
}