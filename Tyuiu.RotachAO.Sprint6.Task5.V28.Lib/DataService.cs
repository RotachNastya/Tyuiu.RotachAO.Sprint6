using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RotachAO.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {

        public int len = 25;

        public double[] LoadFromDataFile(string path)
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            // Преобразуем строки в числа и фильтруем их
            double[] numsArray = lines
                .Select(line => Convert.ToDouble(line))
                .Where(val => val != 0) // Убираем нули
                .Select(val => Math.Round(val, 3)) // Округляем до 3 знаков после запятой
                .ToArray();

            // Выводим числа, которые меньше 10
            foreach (var num in numsArray.Where(val => val < 10))
            {
                Console.WriteLine(num);
            }

            return numsArray;
        }
    }
}
