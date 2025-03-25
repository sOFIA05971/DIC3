using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC3
{
    internal class ControladorVehiculo
    {
        Dictionary<int, VehiculoCoche> diccionariocoche = new Dictionary<int, VehiculoCoche>();
        Dictionary<int, VehiculoCamion> diccionariocamion = new Dictionary<int, VehiculoCamion>();
        VehiculoCamion vca = new VehiculoCamion();
        VehiculoCoche vco = new VehiculoCoche();


        public void AddCoche()
        {
            Console.WriteLine("Dame ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame marca:");
            vco.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo");
            vco.Modelo = Console.ReadLine();
            Console.WriteLine("Dame anio");
            vco.Anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame numero de puertas:");
            vco.NumeroPuertas = Convert.ToInt32(Console.ReadLine());

            diccionariocoche.Add(id, new VehiculoCoche(vco.ID, vco.Marca, vco.Modelo, vco.Anio, vco.NumeroPuertas));

        }

        public void MostrarCoche()
        {
            foreach (var coch in diccionariocoche)
            {
                Console.WriteLine($"ID:{coch.Value.ID}");
                Console.WriteLine($"Marca:{coch.Value.Marca}");
                Console.WriteLine($"Modelo:{coch.Value.Modelo}");
                Console.WriteLine($"Anio:{coch.Value.Anio}");
                Console.WriteLine($"Numero de puertas:{coch.Value.NumeroPuertas}");
            }
        }

        public void EliminarCoche()
        {
            Console.WriteLine("Dame ID a eliminar:");
            int iD = Convert.ToInt32(Console.ReadLine());

            diccionariocoche.Remove(iD);
        }

        public void ActualizarCoche()
        {
            Console.WriteLine("Dame ID a actualizar:");
            int id = Convert.ToInt32(Console.ReadLine());

            var coche = diccionariocoche.FirstOrDefault(x => x.Value.ID == id);

            Console.WriteLine("Dame nuevo ID:");
            coche.Value.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame nueva marca:");
            coche.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame nuevo modelo:");
            coche.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame nuevo anio");
            coche.Value.Anio = Convert.ToInt32(Console.ReadLine());

        }

        public void AddCamion()
        {
            Console.WriteLine("Dame ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame marca:");
            vca.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo");
            vca.Modelo = Console.ReadLine();
            Console.WriteLine("Dame anio");
            vca.Anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame capacidad de carga:");
            vca.CapacidadCarga = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Add(id, new VehiculoCamion(vca.ID, vca.Marca, vca.Modelo, vca.Anio, vca.CapacidadCarga));

        }
        public void MostrarCamion()
        {
            foreach (var cam in diccionariocamion)
            {
                Console.WriteLine($"ID:{cam.Value.ID}");
                Console.WriteLine($"Marca:{cam.Value.Marca}");
                Console.WriteLine($"Modelo:{cam.Value.Modelo}");
                Console.WriteLine($"Anio:{cam.Value.Anio}");
                Console.WriteLine($"capacidad de carga:{cam.Value.CapacidadCarga}");
            }
        }
        public void ElimnarCM()
        {
            Console.WriteLine("Dame ID a eliminar:");
            int iD = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Remove(iD);

        }
        public void ActualizarCamion() 
        {
            Console.WriteLine("Dame ID a actualizar:");
            int id = Convert.ToInt32(Console.ReadLine());

            var camion = diccionariocoche.FirstOrDefault(x => x.Value.ID == id);

            Console.WriteLine("Dame nuevo ID:");
            camion.Value.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame nueva marca:");
            camion.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame nuevo modelo:");
            camion.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame nuevo anio");
            camion.Value.Anio = Convert.ToInt32(Console.ReadLine());
        }
    }
    
}
