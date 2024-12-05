using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedotkinNE.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            double radius = 2;
            double radius2 = 1;

            double distance = Math.Sqrt(x * x + y * y);
            if ((distance < radius) && (distance > radius2))
            {
                return res = true;
            }
            else if ((distance == radius) || (distance == radius2))
            {
                return res = true;
            }
            else
            {
                return res = false;
            }
        }
    }
}
