using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FedotkinNE.Sprint2.Task1.V6.Lib
{


    public class DataService : ISprint2Task1V6
    {

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[] {
            !(a > b),
            !(c >= d) && (a == b),
            (a > b) || (c < d),
            !(d > b) && (c != a),
            (a > b) || (c < d),
            !(a == b) && (c > d)
        };
            return result;
        }
    }
}

