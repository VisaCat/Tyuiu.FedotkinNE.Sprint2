using Tyuiu.FedotkinNE.Sprint2.Task4.V20.Lib;

namespace Tyuiu.FedotkinNE.Sprint2.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);

        }
    }
}
