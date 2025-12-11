using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoRecorteLiangBarsky
    {
        private readonly float XMin = 83;
        private readonly float XMax = 166;
        private readonly float YMin = 83;
        private readonly float YMax = 166;

        public bool ClipLine(PointF p0, PointF p1, out PointF newP0, out PointF newP1)
        {
            float dx = p1.X - p0.X;
            float dy = p1.Y - p0.Y;

            float t0 = 0f, t1 = 1f;

            bool ok = ClipTest(-dx, p0.X - XMin, ref t0, ref t1);
            if (ok) ok = ClipTest(dx, XMax - p0.X, ref t0, ref t1);
            if (ok) ok = ClipTest(-dy, p0.Y - YMin, ref t0, ref t1);
            if (ok) ok = ClipTest(dy, YMax - p0.Y, ref t0, ref t1);

            if (!ok)
            {
                newP0 = p0;
                newP1 = p1;
                return false;
            }

            newP0 = new PointF(p0.X + t0 * dx, p0.Y + t0 * dy);
            newP1 = new PointF(p0.X + t1 * dx, p0.Y + t1 * dy);
            return true;
        }

        private bool ClipTest(float p, float q, ref float t0, ref float t1)
        {
            if (p == 0) return q >= 0;
            float r = q / p;

            if (p < 0)
            {
                if (r > t1) return false;
                if (r > t0) t0 = r;
            }
            else if (p > 0)
            {
                if (r < t0) return false;
                if (r < t1) t1 = r;
            }

            return true;
        }
    }
}
