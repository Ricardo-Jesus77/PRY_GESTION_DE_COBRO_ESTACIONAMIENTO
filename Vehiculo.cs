using System;

namespace Estacionamiento
{
    public abstract class Vehiculo
    {
        public int HorasEstancia { get; set; }

        public Vehiculo(int horas)
        {
            HorasEstancia = horas;
        }

        public abstract double CalcularTarifa();
    }
}