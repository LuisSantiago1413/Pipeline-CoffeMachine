using Maquina_de_café_2;
using NUnit.Framework;


namespace Test_Maquina_De_Cafe
{
    public class TestMaquina
    {
        Azucarero azucarero = new Azucarero(100);
        Vaso vasoPequeño = new Vaso(30, 1);
        Vaso vasoMediano = new Vaso(40, 2);
        Vaso vasoGrande = new Vaso(60, 3);
        Cafetera cafetera = new Cafetera(200);
        MaquinaCafe maquinaCafe = new MaquinaCafe();
        int tamañoVaso, cantidadCafe, cantidadAzucar;

        [Test]
        public void deberiaDevolverUnVasoPequeño()
        {
            Assert.AreEqual(1, vasoPequeño.getTamañoVaso());
        }

        [Test]
        public void deberiaDevolverUnVasoMediano()
        {
            Assert.AreEqual(2, vasoMediano.getTamañoVaso());
        }

        [Test]
        public void deberiaDevolverUnVasoGrande()
        {
            Assert.AreEqual(3, vasoGrande.getTamañoVaso());
        }

        [Test]
        public void deberiaDevolverNoHayCafe()
        {
            tamañoVaso = 1;
            cantidadCafe = 201;
            cantidadAzucar = 100;
            Assert.AreEqual("No hay cafe", maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar));
        }

        [Test]
        public void deberiaDevolverNoHayAzucar()
        {
            tamañoVaso = 1;
            cantidadCafe = 60;
            cantidadAzucar = 101;
            Assert.AreEqual("No hay suficiente azucar", maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar));
        }
        [Test]
        public void deberiaDevolverFelicitaciones()
        {
            tamañoVaso = 1;
            cantidadCafe = 60;
            cantidadAzucar = 80;
            string tamaño = "pequeño";
            Assert.AreEqual("Felicidades, aquí tiene su cafe tamaño " + tamaño + " con " + cantidadCafe + " ml y "
                    + cantidadAzucar + " de azucar. Quedan " + (vasoPequeño.getCantidadVasos() -1) 
                    + " vasos " + tamaño + "s disponibles", 
                    maquinaCafe.getVasoDeCafe(tamañoVaso, cantidadCafe, cantidadAzucar));
        }
    }
}
         
    

