using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoRecorteNichollLeeNicholl
    {
        private readonly float XMin = 83;
        private readonly float XMax = 166;
        private readonly float YMin = 83;
        private readonly float YMax = 166;

        private int RegionCode(PointF p)
        {
            int c = 0;
            if (p.X < XMin) c |= 1;
            else if (p.X > XMax) c |= 2;
            if (p.Y < YMin) c |= 4;
            else if (p.Y > YMax) c |= 8;
            return c;
        }

        public bool ClipLine(PointF p0, PointF p1, out PointF cp0, out PointF cp1)
        {
            cp0 = p0;
            cp1 = p1;

            int code0 = RegionCode(p0);
            int code1 = RegionCode(p1);

            float dx = p1.X - p0.X;
            float dy = p1.Y - p0.Y;

            while (true)
            {
                if ((code0 | code1) == 0) return true;     // Accept
                if ((code0 & code1) != 0) return false;    // Reject

                int codeOut = (code0 != 0) ? code0 : code1;
                float x = 0, y = 0;

                if ((codeOut & 8) != 0) // TOP
                {
                    x = p0.X + dx * (YMax - p0.Y) / dy;
                    y = YMax;
                }
                else if ((codeOut & 4) != 0) // BOTTOM
                {
                    x = p0.X + dx * (YMin - p0.Y) / dy;
                    y = YMin;
                }
                else if ((codeOut & 2) != 0) // RIGHT
                {
                    y = p0.Y + dy * (XMax - p0.X) / dx;
                    x = XMax;
                }
                else if ((codeOut & 1) != 0) // LEFT
                {
                    y = p0.Y + dy * (XMin - p0.X) / dx;
                    x = XMin;
                }

                if (codeOut == code0)
                {
                    cp0 = new PointF(x, y);
                    code0 = RegionCode(cp0);
                }
                else
                {
                    cp1 = new PointF(x, y);
                    code1 = RegionCode(cp1);
                }
            }
        }
    }
}

