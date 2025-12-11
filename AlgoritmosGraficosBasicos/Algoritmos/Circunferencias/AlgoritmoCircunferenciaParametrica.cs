using AlgoritmosGraficosBasicos.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosBasicos.Algoritmos
{
    internal class AlgoritmoCircunferenciaParametrica
    {
        public List<Punto> CalcularCircunferencia(Punto centro, int radio)
        {
            List<Punto> puntos = new List<Punto>();

            for (double theta = 0; theta <= 2 * Math.PI; theta += 0.01)
            {
                int x = (int)Math.Round(centro.X + radio * Math.Cos(theta));
                int y = (int)Math.Round(centro.Y + radio * Math.Sin(theta));
                puntos.Add(new Punto(x, y));
            }

            return puntos;
        }
    }
}