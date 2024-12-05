using Tyuiu.FedotkinNE.Sprint2.Task5.V2.Lib;
namespace Tyuiu.FedotkinNE.Sprint2.Task5.V2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());

            string season;

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Осень";
                    break;
                default:
                    season = "Некорректный номер месяца";
                    break;
            }

            Console.WriteLine($"Месяц {month} относится к {season}");
        }
    }
}
