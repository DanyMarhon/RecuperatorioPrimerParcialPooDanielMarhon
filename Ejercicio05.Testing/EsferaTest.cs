using Ejercicio01.Entidades;

namespace Ejercicio05.Testing
{
    [TestClass]
    public class EsferaTest
    {

        [TestMethod]
        public void GetArea_CalcularTest()
        {
            // Arrange
            var esferaArea = new Esfera(1);
            double areaCorrecta = 12.56637;

            // Act
            double areaActual = esferaArea.GetArea();

            // Assert
            Assert.AreEqual(areaCorrecta, areaActual, 1e-5);
        }

        [TestMethod]
        public void GetVolumen_CalcularTest()
        {
            // Arrange
            var esferaVolumen = new Esfera(1);
            double volumenCorrecto = 4.18879;

            // Act
            double volumenActual = esferaVolumen.GetVolumen();

            // Assert
            Assert.AreEqual(volumenCorrecto, volumenActual, 1e-5);
        }
    }
}