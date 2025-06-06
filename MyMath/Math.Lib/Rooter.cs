using System;

namespace Math.Lib
{
    /// <summary>
    /// Proporciona operaciones matemáticas relacionadas con raíces cuadradas.
    /// </summary>
    public class Rooter
    {
        /// <summary>
        /// Calcula la raíz cuadrada de un número no negativo utilizando el método de Newton-Raphson.
        /// </summary>
        /// <param name="input">Número al que se le desea calcular la raíz cuadrada.</param>
        /// <returns>La raíz cuadrada del número de entrada.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Se lanza cuando el valor ingresado es negativo.</exception>
        public double SquareRoot(double input)
        {
            if (input < 0.0)
                throw new ArgumentOutOfRangeException(
                    paramName: nameof(input), 
                    message: "El valor ingresado es invalido, solo se puede ingresar números positivos");

            if (input == 0.0)
                return 0.0;

            double result = input;
            double previousResult = -input;

            while (System.Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }

            return result;
        }
    }
}
