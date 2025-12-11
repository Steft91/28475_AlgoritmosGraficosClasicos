using System;
using System.Collections.Generic;
using AlgoritmosGraficosBasicos.Utils;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoDDA
    {
        public List<Punto> CalcularLinea(Punto inicio, Punto fin)
        {
            List<Punto> puntos = new List<Punto>();

            int dx = fin.X - inicio.X;
            int dy = fin.Y - inicio.Y;

            int pasos = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xIncremento = dx / (float)pasos;
            float yIncremento = dy / (float)pasos;

            float x = inicio.X;
            float y = inicio.Y;

            for (int i = 0; i <= pasos; i++)
            {
                puntos.Add(new Punto((int)Math.Round(x), (int)Math.Round(y)));
                x += xIncremento;
                y += yIncremento;
            }

            return puntos;
        }
    }
}
