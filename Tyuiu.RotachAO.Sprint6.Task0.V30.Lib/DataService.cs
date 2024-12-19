using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RotachAO.Sprint6.Task0.V30.Lib
{
    public class DataService : ISprint6Task0V30
    {
        public double Calculate(int x)
        {
            if (x < -3)
            {
                throw new ArgumentOutOfRangeException(nameof(x), "Аргумент x должен быть >= -3, чтобы избежать комплексных значений.");
            }

            return Math.Round(x * Math.Sqrt(x + 3),3);
        }
    }
}
