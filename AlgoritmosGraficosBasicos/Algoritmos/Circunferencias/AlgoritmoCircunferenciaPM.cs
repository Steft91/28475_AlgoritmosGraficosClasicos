using AlgoritmosGraficosBasicos.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoCircunferenciaPM

    {
        public List<Punto> CalcularCircunferencia(Punto centro, int radio)
        {
            List<Punto> puntos = new List<Punto>();

            int x = 0;
            int y = radio;
            int d = 3 - 2 * radio; //d = decision parameter

            while (x <= y)
            {
                AgregarOctantes(puntos, centro, x, y);
                if (d < 0)
                {
                    d += 4 * x + 6;
                }
                else
                {
                    d += 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }

            return puntos;
        }

        private void AgregarOctantes(List<Punto> lista, Punto centro, int x, int y)
        {
            int cx = centro.X;
            int cy = centro.Y;

            lista.Add(new Punto(cx + x, cy + y));
            lista.Add(new Punto(cx - x, cy + y));
            lista.Add(new Punto(cx + x, cy - y));
            lista.Add(new Punto(cx - x, cy - y));
            lista.Add(new Punto(cx + y, cy + x));
            lista.Add(new Punto(cx - y, cy + x));
            lista.Add(new Punto(cx + y, cy - x));
            lista.Add(new Punto(cx - y, cy - x));
        }
    }
}
