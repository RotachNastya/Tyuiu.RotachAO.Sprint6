using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RotachAO.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
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

        public static double Calculate(double x)
        {
            double denominator = Math.Sin(x) + 3;
            if (Math.Abs(denominator) < 1e-9) // Проверка на деление на ноль
            {
                return 0;
            }

            double result = (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
            return Math.Round(result, 2); // Округление до 2 знаков
        }
    }
}
