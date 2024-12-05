using Tyuiu.FedotkinNE.Sprint2.Task5.V2.Lib;
namespace Tyuiu.FedotkinNE.Sprint2.Task5.V2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());


            DataService ds = new DataService();
            string time = ds.FindMonthSeason(month);




            Console.WriteLine($"Месяц {month} относится к {time}");
        }
    }
}
