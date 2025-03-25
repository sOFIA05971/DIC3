using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DIC3.Program;

namespace DIC3
{
    internal class Program
    {
        public enum Menu

        {
            ADDcr = 1, mostrarCR, EliminarCR, ActulizarCR, ADDcam, MostrarCM, EliminarCM, ActualizarCm
        }
        static void Main(string[] args)
        {
            ControladorVehiculo Con=new ControladorVehiculo();
            while (true)
            {
                switch (menu())
                {
                    case Menu.ADDcr:
                        Con.AddCoche();

                        break;
                    case Menu.mostrarCR:
                        Con.MostrarCoche();
                        break;
                    case Menu.EliminarCR:
                        Con.EliminarCoche();
                        break;
                    case Menu.ActulizarCR:
                        Con.ActualizarCoche();
                        break;
                    case Menu.ADDcam:
                        Con.AddCamion();
                        break;
                    case Menu.MostrarCM:
                        Con.MostrarCamion();
                        break;
                    case Menu.EliminarCM:
                        Con.ElimnarCM();
                        break;
                    case Menu.ActualizarCm:
                        Con.ActualizarCamion();
                        break;
                    default:
                        break;
                }
            }
            }
            static Menu menu()
            {

                Console.WriteLine("1) Agregar carro");
                Console.WriteLine("2) Mostrar carros");
                Console.WriteLine("3) Eliminar carros");
                Console.WriteLine("4) Actualizar carros");
                Console.WriteLine("5) Agregar camion");
                Console.WriteLine("6) mostrar camion");
                Console.WriteLine("7) Eliminar camion");
                Console.WriteLine("8) Actualizar camion");
                Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
                return opc;
            }
        }
    }
