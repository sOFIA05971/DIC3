using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DIC3
{
    internal class VehiculoCoche : BaseVehiculo
    {
        public VehiculoCoche() { }
        public VehiculoCoche(int iD, string marca, string modelo, int anio,int numeroPuertas)
        :base(iD,marca,modelo,anio)    
        {
            NumeroPuertas = numeroPuertas;
        }

        public int NumeroPuertas { get; set; }

    }
}
