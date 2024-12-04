using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedotkinNE.Sprint2.Task0.V2.Lib
{
    public class DataService : ISprint2Task0V2
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x != y;
            result[1] = x == y;
            result[2] = x < y;
            result[3] = x >= y;
            result[4] = x > y;
            result[5] = x >= y;

            return result;
        }
    }
}