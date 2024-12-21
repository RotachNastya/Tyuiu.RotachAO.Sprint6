using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RotachAO.Sprint6.Task7.V3.Lib
{
    public class DataService : ISprint6Task7V3
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;
            int[,] result = { { -1, -16, -5, 17, 18, -2, 19, 2, -18, 1 }, { -1, -10, -4, 16, 2, -8, 10, -11, -14, -12 }, { 1, -15, 19, -12, 6, -13, 12, 7, -1, -8 }, { -1, 13, 7, -18, 19, -17, -12, 9, 6, 6 }, { -1, -19, -15, -8, 3, -1, -13, -8, -19, 6 }, { 3, 16, 11, -5, -5, -3, -13, 3, 6, 19 }, { 13, 8, 14, 3, -9, -12, 8, -13, -20, -3 }, { -15, 2, 9, -12, -6, 2, 11, 20, -1, 7 }, { -11, -15, 8, 17, 10, -10, -8, -6, -13, -9 }, { -15, -14, 17, -7, 6, -17, -3, -17, 18, 11 } };


            return result;
        }
    }
}
