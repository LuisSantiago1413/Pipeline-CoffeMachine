using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_café_2
{
    internal class Program
    {
        private static Azucarero azucarero = new Azucarero(100);
        private static Vaso vasoPequeño = new Vaso(30, 1);
        private static Vaso vasoMediano = new Vaso(40, 2);
        private static Vaso vasoGrande = new Vaso(60, 3);
        private static Cafetera cafetera = new Cafetera(200);
        private static MaquinaCafe maquinaCafe = new MaquinaCafe();
        private static int tamañoVaso, cantidadCafe, cantidadAzucar;
        static void Main(string[] args)
        {
            bool showMenu = true;
            /*while (showMenu) 
            {
                showMenu = MainMenu();
            }*/
            vasoMediano.hayVasosDisponibles(1);
            Console.ReadKey();
        }

        private bool MainMenu()
        {

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Bienvenidos a la maquina de cafe");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Seleccione un tamaño de vaso:");
            Console.WriteLine("1. Pequeño: " + vasoPequeño.getCantidadVasos());
            Console.WriteLine("2. Mediano: " + vasoMediano.getCantidadVasos());
            Console.WriteLine("3. Grande: " + vasoGrande.getCantidadVasos());
            Console.WriteLine("4. Salir");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            tamañoVaso = int.Parse(Console.ReadLine());
            switch (tamañoVaso)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado un vaso pequeño");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Diga que cantidad de café quiere: " + cafetera.getCantidadCafe() + " ml");
                    cantidadCafe = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Diga la cantidad de azucar que quiere: " + azucarero.getCantidadAzucar() + " gs");
                    cantidadAzucar = int.Parse(Console.ReadLine());
                    Console.WriteLine(maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar));
                    PressEnterToContinue();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado un vaso mediano");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Diga que cantidad de café quiere: " + cafetera.getCantidadCafe()+ " ml");
                    cantidadCafe = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Diga la cantidad de azucar que quiere: " + azucarero.getCantidadAzucar() + " gs");
                    cantidadAzucar = int.Parse(Console.ReadLine());
                    Console.WriteLine(maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar)); 
                    PressEnterToContinue();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado un vaso grande");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Diga que cantidad de café quiere: " + cafetera.getCantidadCafe() + " ml");
                    Console.WriteLine("");
                    cantidadCafe = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Diga la cantidad de azucar que quiere: " + azucarero.getCantidadAzucar() + " gs");
                    cantidadAzucar = int.Parse(Console.ReadLine());
                    Console.WriteLine(maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar));
                    PressEnterToContinue();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Digite una opción correcta, por favor");
                    PressEnterToContinue();
                    break;
            }
            return true;
        }

        private static void PressEnterToContinue()
        {
            Console.WriteLine("\r\nPresiona enter para volver al menú principal");
            Console.ReadLine();
        }
    }
}
