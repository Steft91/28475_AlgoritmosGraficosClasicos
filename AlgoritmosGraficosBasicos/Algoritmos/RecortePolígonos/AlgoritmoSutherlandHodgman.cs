using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoSutherlandHodgman
    {
        private RectangleF clip;

        public AlgoritmoSutherlandHodgman()
        {
            clip = new RectangleF(83, 83, 83, 83);
        }

        public List<PointF> ClipPolygon(List<PointF> poly)
        {
            return ClipEdge(
                   ClipEdge(
                   ClipEdge(
                   ClipEdge(poly, "LEFT"), "RIGHT"), "TOP"), "BOTTOM");
        }

        private List<PointF> ClipEdge(List<PointF> input, string edge)
        {
            List<PointF> output = new List<PointF>();

            for (int i = 0; i < input.Count; i++)
            {
                PointF A = input[i];
                PointF B = input[(i + 1) % input.Count];

                bool Ain = Inside(A, edge);
                bool Bin = Inside(B, edge);

                if (Ain && Bin)
                {
                    output.Add(B);
                }
                else if (Ain && !Bin)
                {
                    output.Add(Intersect(A, B, edge));
                }
                else if (!Ain && Bin)
                {
                    output.Add(Intersect(A, B, edge));
                    output.Add(B);
                }
            }

            return output;
        }

        private bool Inside(PointF p, string edge)
        {
            switch (edge)
            {
                case "LEFT": return p.X >= clip.Left;
                case "RIGHT": return p.X <= clip.Right;
                case "TOP": return p.Y >= clip.Top;
                case "BOTTOM": return p.Y <= clip.Bottom;
            }
            return false;
        }

        private PointF Intersect(PointF A, PointF B, string edge)
        {
            float dx = B.X - A.X;
            float dy = B.Y - A.Y;

            switch (edge)
            {
                case "LEFT":
                    return new PointF(clip.Left, A.Y + dy * (clip.Left - A.X) / dx);
                case "RIGHT":
                    return new PointF(clip.Right, A.Y + dy * (clip.Right - A.X) / dx);
                case "TOP":
                    return new PointF(A.X + dx * (clip.Top - A.Y) / dy, clip.Top);
                case "BOTTOM":
                    return new PointF(A.X + dx * (clip.Bottom - A.Y) / dy, clip.Bottom);
            }

            return A;
        }
    }
}
