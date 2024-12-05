using System;
using Tyuiu.FedotkinNE.Sprint2.Task6.V15.Lib;

namespace Tyuiu.FedotkinNE.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("Введите номер дня (k): ");
            int k = int.Parse(Console.ReadLine());

            // Убедимся, что k в пределах от 1 до 365
            if (k < 1 || k > 365)
            {
                Console.WriteLine("Пожалуйста, введите число от 1 до 365.");
                return;
            }
            string Res = ds.FindDayName(k);
            Console.WriteLine($"День недели для {k}-го дня: {Res}");
        }
    }
}
