using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC3
{
    internal class VehiculoCamion : BaseVehiculo
    {
        public VehiculoCamion() { }
        public VehiculoCamion(int iD, string marca, string modelo, int anio, int capacidadCarga)
        : base(iD, marca, modelo, anio)
        {
            CapacidadCarga = capacidadCarga;
        }

        public int CapacidadCarga { get; set; }
    }
}
