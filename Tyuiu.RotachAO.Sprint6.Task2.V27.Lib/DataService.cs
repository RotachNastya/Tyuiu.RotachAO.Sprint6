using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RotachAO.Sprint6.Task2.V27.Lib
{
    public class DataService : ISprint6Task2V27
    {
        public static double Calculate(double x)
        {
            double denominator = Math.Cos(x) -2*x;
            if (Math.Abs(denominator) < 1e-9) // Проверка на деление на ноль
            {
                return 0;
            }

            double result = (2*x -3) / denominator + 5 * x - Math.Sin(x);
            return Math.Round(result, 2); // Округление до 2 знаков
        }

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] results = new double[size];

            for (int i = 0; i < size; i++)
            {
                double x = startValue + i;
                results[i] = Calculate(x);
            }

            return results;
        }
    }
}
