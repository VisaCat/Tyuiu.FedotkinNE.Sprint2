using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedotkinNE.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string time;
            switch (value)
            {
                case 12:
                case 1:
                case 2:
                    time = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    time = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    time = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    time = "Осень";
                    break;
                default:
                    time = "Некорректный номер месяца";
                    break;
            }
            return time;
        }
    }
}
