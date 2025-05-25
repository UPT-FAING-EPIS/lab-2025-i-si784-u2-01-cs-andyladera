namespace Math.Lib //Espacio de nombre que contiene clases y métodos
{
    public class Rooter //Nombre de la clase
    {
        public double SquareRoot(double input) //Método
        {
            if (input <= 0.0) throw new ArgumentOutOfRangeException();
            double result = input;
            double previousResult = -input;
            while (System.Math.Abs(previousResult - result)
                > result / 1000)
            {
            previousResult = result;
            result = result - (result * result - input) / (2 * result);
            }
            return result;
        }
    }
}