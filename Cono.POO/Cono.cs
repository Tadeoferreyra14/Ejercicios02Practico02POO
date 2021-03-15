using System;

namespace Ejercicios02Practico02.POO
{
    public class Cono
    {
        public double altura { get; set; }
        public double generatriz { get; set; }
        public double radiodegiro { get; set; }

        public double GetArea()
        {
            return Math.PI* radiodegiro *(radiodegiro + generatriz);
        }
        public double GetVolumen()
        {
            return Math.PI* Math.Pow(radiodegiro, 2) * altura / 3;
        }
    }
}
