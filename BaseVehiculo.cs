using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC3
{
    internal class BaseVehiculo
    {
        public BaseVehiculo() { }
        public BaseVehiculo(int iD, string marca, string modelo, int anio)
        {
            ID = iD;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

    }
}
