using Tyuiu.FedotkinNE.Sprint2.Task1.V6.Lib;

namespace Tyuiu.FedotkinNE.Sprint2.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 915;
            int b = 169;
            int c = 174;
            int d = 133;
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            // Print the results
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
