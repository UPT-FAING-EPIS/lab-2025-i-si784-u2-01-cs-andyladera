using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math.Lib;

namespace Math.Tests
{
    /// <summary>
    /// Contiene pruebas unitarias para verificar el funcionamiento de la clase <see cref="Rooter"/>.
    /// </summary>
    [TestClass]
    public class RooterTests
    {
        /// <summary>
        /// Prueba básica para verificar que SquareRoot retorna el valor esperado para una entrada conocida.
        /// </summary>
        [TestMethod]
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter();
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        /// <summary>
        /// Prueba la función SquareRoot con una amplia gama de valores de entrada.
        /// </summary>
        [TestMethod]
        public void RooterValueRange()
        {
            Rooter rooter = new Rooter();
            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
                RooterOneValue(rooter, expected);
        }

        /// <summary>
        /// Método auxiliar que verifica la raíz cuadrada de un solo valor.
        /// </summary>
        /// <param name="rooter">Instancia de la clase Rooter.</param>
        /// <param name="expectedResult">El valor cuya raíz cuadrada se desea comprobar.</param>
        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }

        /// <summary>
        /// Verifica que se lance una excepción al ingresar un número negativo.
        /// </summary>
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

        /// <summary>
        /// Verifica que el mensaje de la excepción por entrada negativa sea el esperado.
        /// </summary>
        [TestMethod]
        public void RooterTestNegativeInputWithMessage()
        {
            Rooter rooter = new Rooter();

            try
            {
                rooter.SquareRoot(-5);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "El valor ingresado es invalido, solo se puede ingresar números positivos");
                return;
            }

            Assert.Fail("Se esperaba una excepción ArgumentOutOfRangeException.");
        }
    }
}
