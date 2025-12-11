using AlgoritmosGraficosBasicos.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoCircunferenciaDDA
    {
        public List<Punto> CalcularCircunferencia(Punto centro, int radio)
        {
            List<Punto> puntos = new List<Punto>();

            int step = 360 * 4; // Más puntos para suavizar la curva

            for (int i = 0; i < step; i++)
            {
                float angulo = i * (float)(Math.PI / 180f) / 4f; // Incremento pequeño

                float x = centro.X + radio * (float)Math.Cos(angulo);
                float y = centro.Y + radio * (float)Math.Sin(angulo);

                Punto p = new Punto((int)Math.Round(x), (int)Math.Round(y));

                if (!puntos.Contains(p)) // Evita puntos repetidos
                {
                    puntos.Add(p);
                }
            }

            return puntos;
        }

    }
}