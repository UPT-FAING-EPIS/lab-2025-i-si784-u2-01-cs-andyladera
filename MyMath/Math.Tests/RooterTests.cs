//RooterTests.cs es un archivo de prueba unitaria utilizando MSTest
// ---
//Espacio de nombres para poder usar las clases y atributos de MSTest
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using Math.Lib;

namespace Math.Tests //Nombre del namespace
{
    [TestClass] //Indica que la clase contiene métodos de prueba
    public class RooterTests //Clase de prueba
    {
        [TestMethod] //Indica que el siguiente método es una prueba unitaria individual ejecutada por MSTest
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter(); //Instancia de clase Rooter
            double expectedResult = 2.0; //valor esperado
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input); //Llama al método SqueareRoot con el valor 4.0
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100); //Verifica que expectedResult sea igual a actualResult
                                                                                        //dentro un margen de error delta
                                                                                        //margen de error 2.0/100 = 0.02
        }
        
        [TestMethod]
        public void RooterValueRange()
        {
            Rooter rooter = new Rooter();
            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
                RooterOneValue(rooter, expected);
        }
        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }

        [TestMethod]
        public void RooterTestNegativeInputx()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

    }
}