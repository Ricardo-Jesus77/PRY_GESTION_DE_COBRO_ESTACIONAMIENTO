using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRY_GESTION_DE_COBRO_ESTACIONAMIENTO
{
    internal class Automovil:Vehiculo
    {
        public abstract class automovil
        {
            public int Horas_estancia {  get; set; }
            
            public automovil(int horas)
            {
                Horas_estancia = horas;
            }
            public abstract double CalcularTarifa();
        }

    }
}
