using Tyuiu.FedotkinNE.Sprint2.Task3.V29.Lib;

namespace Tyuiu.FedotkinNE.Sprint2.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            double y = ds.Calculate(x);
            Console.WriteLine(Math.Round(y, 3));
        }
    }
}
