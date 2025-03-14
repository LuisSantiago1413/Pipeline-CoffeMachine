using Maquina_de_café_2;
using NUnit.Framework;

namespace Test_Maquina_De_Cafe
{
    public class TestCafetera
    {
        [Test]
        public void deberiaDevolverTrueSiHayCafeSuficiente()
        {
            //La cafetera devolvera true si el cafe dado se puede sustraer de la cafetera
            Cafetera cafetera = new Cafetera(100);
            bool result = cafetera.hayCafeDisponible(20);
            Assert.IsTrue(result);
        }

        [Test]
        public void deberiaDevolverFalseSiNoHayCafeSuficiente()
        {
            //La cafetera devolvera false si el cafe dado no se puede sustraer de la cafetera
            Cafetera cafetera = new Cafetera(50);
            bool result = cafetera.hayCafeDisponible(60);
            Assert.IsFalse(result);
        }

        [Test]
        public void deberiaRestarCafe()
        {
            //La cafetera debera restar el cafe que se le pide, y devolver el valor esperado
            Cafetera cafetera = new Cafetera(80);
            cafetera.restarCafe(50);
            Assert.AreEqual(30, cafetera.getCantidadCafe());
        }
    }

    public class Cafetera
{
    private int cantidadCafe;
    private int capacidadMaxima = 100;

    public Cafetera(int cantidadInicial)
    {
        cantidadCafe = cantidadInicial;
    }

    public bool hayCafeDisponible(int cantidad)
    {
        return cantidadCafe >= cantidad;
    }

    public void restarCafe(int cantidad)
    {
        if (hayCafeDisponible(cantidad))
        {
            cantidadCafe -= cantidad;
        }
    }

    public void agregarCafe(int cantidad)
    {
        if (cantidadCafe + cantidad <= capacidadMaxima)
        {
            cantidadCafe += cantidad;
        }
        else
        {
            cantidadCafe = capacidadMaxima; // No puede superar la capacidad máxima
        }
    }

    public int getCantidadCafe()
    {
        return cantidadCafe;
    }
}
}
