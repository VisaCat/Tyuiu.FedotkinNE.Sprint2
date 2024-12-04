using Tyuiu.FedotkinNE.Sprint2.Task0.V2.Lib;

namespace Tyuiu.FedotkinNE.Sprint2.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 123;
            int y = 123;
            bool[] result = ds.GetCompareOperations(x, y);

            // Print the results
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
