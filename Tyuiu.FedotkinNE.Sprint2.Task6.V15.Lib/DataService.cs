using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedotkinNE.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            string dayOfWeek;
            switch ((k - 1) % 7)
            {
                
                case 0:
                dayOfWeek = "Понедельник";
                break;
            case 1:
                dayOfWeek = "Вторник";
                break;
            case 2:
                dayOfWeek = "Среда";
                break;
            case 3:
                dayOfWeek = "Четверг";
                break;
            case 4:
                dayOfWeek = "Пятница";
                break;
            case 5:
                dayOfWeek = "Суббота";
                break;
            case 6:
                dayOfWeek = "Воскресенье";
                break;
            default:
                dayOfWeek = "Ошибка"; // Этот случай не должен происходить
                break;
            }
            return dayOfWeek;
        }
    }
}
