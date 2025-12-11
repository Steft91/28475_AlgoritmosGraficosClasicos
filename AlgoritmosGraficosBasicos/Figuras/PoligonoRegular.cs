using System;
using System.Collections.Generic;
using AlgoritmosGraficosBasicos.Utils;

namespace AlgoritmosGraficosBasicos.Figuras
{
    internal class PoligonoRegular
    {
        public List<Punto> CalcularVertices(Punto centro, int radio, int lados)
        {
            List<Punto> vertices = new List<Punto>();
            double angulo = 2 * Math.PI / lados;

            for (int i = 0; i < lados; i++)
            {
                int x = (int)(centro.X + radio * Math.Cos(i * angulo));
                int y = (int)(centro.Y + radio * Math.Sin(i * angulo));
                vertices.Add(new Punto(x, y));
            }

            return vertices;
        }
    }
}