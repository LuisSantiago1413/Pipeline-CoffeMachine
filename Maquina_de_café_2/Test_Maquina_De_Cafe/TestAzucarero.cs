using Maquina_de_café_2;
using NUnit.Framework;

namespace Test_Maquina_De_Cafe
{
    public class TestAzucarero
    {
        [Test]
        public void deberiaDevolverTrueSiHaySuficienteAzucar()
        {
            //Devolvera true si el azucarero tiene suficiente azucar
            Azucarero azucarero = new Azucarero(100);
            bool result = azucarero.haySuficienteAzucar(50);
            Assert.IsTrue(result);
        }

        [Test]
        public void deberiaDevolverFalseSiNoHaySuficienteAzucar()
        {
            //Devolvera false si el azucarero no tiene suficiente azucar
            Azucarero azucarero = new Azucarero(50);
            bool result = azucarero.haySuficienteAzucar(100);
            Assert.IsFalse(result);
        }

        [Test]
        public void deberiaRestarCantidadDeAzucar()
        {
            Azucarero azucarero = new Azucarero(80);
            azucarero.restarAzucar(20);
            Assert.AreEqual(60, azucarero.getCantidadAzucar());
        }
    }
}
