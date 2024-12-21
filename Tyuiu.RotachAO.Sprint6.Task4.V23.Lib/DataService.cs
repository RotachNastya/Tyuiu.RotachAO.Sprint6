using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RotachAO.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 * i - 2 == 0) // Проверка на деление на ноль
                {
                    y = 0.0; // Устанавливаем значение по умолчанию (например, 0.0)
                }
                else
                {
                    y = Math.Round(4 - 2 * i + (2 + Math.Cos(i)) / (2 * i - 2), 2);
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
