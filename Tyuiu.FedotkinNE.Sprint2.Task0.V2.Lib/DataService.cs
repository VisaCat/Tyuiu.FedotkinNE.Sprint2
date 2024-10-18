using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedotkinNE.Sprint2.Task0.V2.Lib
{
    public class DataService : ISprint2Task0V2
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x == y-1; // False
            result[1] = x * y > 10000; // True
            result[2] = x / y < 1; // False
            result[3] = x - y >= 0; // True
            result[4] = x != y; // False
            result[5] = x + y > 200; // True

            return result;
        }
    }
}
