using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_café_2
{
    public class Vaso
    {
        private int _vasosDisponibles = 0;
        private int _tamañoVaso = 0;
        public readonly Dictionary<string, string> vasos = new Dictionary<string, string>()
        {
            {"1", "Pequeños"}, //25
            {"2", "Medianos"}, //50
            {"3", "Grandes"}   //75
        };

        public Vaso(int vasosDisponibles, int tamañoVaso)
        {
            setCantidadVasos(vasosDisponibles);
            setTamañoVaso(tamañoVaso);
            
        }

        public int setCantidadVasos(int cantidadVasos)
        {
            if (cantidadVasos < 0)
            {
                Console.WriteLine("No se aceptan valores menores a 0");
                return 0;
            }
            return _vasosDisponibles += cantidadVasos;
        }

        public int getCantidadVasos() 
        { 
            return _vasosDisponibles; 
        }

        public int getTamañoVaso()
        {
            return _tamañoVaso;
        }

        public int setTamañoVaso(int tamañoVaso)
        {
            if (tamañoVaso < 0 && tamañoVaso > 3)
            {
                Console.WriteLine("Error, la maquina no tiene de estos vasos");
                return 0;
            }
            else
            {
                return _tamañoVaso = tamañoVaso;
            }
        }

        public bool hayVasosDisponibles(int tamañoVaso)
        {
            if (tamañoVaso > 3 || tamañoVaso <= 0)
            {
                Console.WriteLine("Este tamaño no se encuentra disponible");
                return false;
            }
            if (_vasosDisponibles <= 0)
            {
                Console.WriteLine("Opcion denegada, no hay vasos");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public int restarVasos(int tamañoVaso)
        {
            if (!hayVasosDisponibles(tamañoVaso))
            {
                return 0;
            }
            _vasosDisponibles --;
            return _vasosDisponibles;
        }
    }
}
