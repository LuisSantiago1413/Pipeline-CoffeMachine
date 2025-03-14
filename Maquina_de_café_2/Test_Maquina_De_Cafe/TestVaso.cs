using Maquina_de_café_2;
using NUnit.Framework;

namespace Test_Maquina_De_Cafe
{
    public class Tests
    {
        [Test]
        public void deberiaDevolverTrueSiHayVasos()
        {
            //La idea es pasarle el tamaño del vaso, y preguntarle si hay de esos vasos
            Vaso vasoPequeño = new Vaso(10,2);
            bool result = vasoPequeño.hayVasosDisponibles(2);
            Assert.IsTrue(result);
        }

        [Test]
        public void deberiaDevolverFalseSiNoHayVasos()
        {
            //Lo mismo, pero aqui decimos que no hay vasos medianos
            Vaso vasoMediano = new Vaso(0,2);
            bool result = vasoMediano.hayVasosDisponibles(2);
            Assert.IsFalse(result);
        }

        [Test]
        public void deberiaRestarCantidadDeVasos()
        {
            //La idea es que el método me reste 1 vaso, por cada vez que lo invoque
            Vaso vasoGrande = new Vaso(10,3);
            int result = vasoGrande.restarVasos(3);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void deberiaDevolverFalseSiNoExisteEseVaso()
        {
            //Si el tipo de vaso no existe, deberia retornar falso
            Vaso vaso = new Vaso(20,1);
            bool result = vaso.hayVasosDisponibles(5);
            Assert.IsFalse(result);
        }
    }
}