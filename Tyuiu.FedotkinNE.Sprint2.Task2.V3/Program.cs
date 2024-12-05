using Tyuiu.FedotkinNE.Sprint2.Task2.V3.Lib;
namespace Tyuiu.FedotkinNE.Sprint2.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки (X и Y):");

            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
        }
    }
}
