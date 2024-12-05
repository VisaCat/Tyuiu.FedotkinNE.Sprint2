using Tyuiu.FedotkinNE.Sprint2.Task7.V15.Lib;

namespace Tyuiu.FedotkinNE.Sprint2.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            // Запрос координат точки у пользователя
            Console.WriteLine("Введите координаты точки (X, Y):");

            Console.Write("X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            bool res;
            Console.WriteLine(res = ds.CheckDotInShadedArea(x, y));
        }
    }
}
