using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FedotkinNE.Sprint2.Task2.V3.Lib



    
{
    public class DataService : ISprint2Task2V3
    {

        public bool CheckDotInShadedArea(int x, int y)
        {
            bool a;
            if ((x >= 3 && x <= 13) && (y >= 3 && y <= 13))
            {
                a = true;
                if (x == 3)
                {
                    if (y == 6)
                    {
                        a = false;
                    }
                    if (y == 7)
                    {
                        a = false;
                    }
                    if (y == 8)
                    {
                        a = false;
                    }
                    if (y == 13)
                    {
                        a = false;
                    }

                }
                if (x == 4)
                {
                    if (y == 6)
                    {
                        a = false;
                    }
                    if (y == 7)
                    {
                        a = false;
                    }
                    if (y == 8)
                    {
                        a = false;
                    }
                    if (y == 10)
                    {
                        a = false;
                    }
                    if (y == 11)
                    {
                        a = false;
                    }
                    if (y == 12)
                    {
                        a = false;
                    }
                    

                }
                if (x == 5)
                {
                    if (y == 11)
                    {
                        a = false;
                    }
                    if (y == 12)
                    {
                        a = false;
                    }
                    
                    if (y == 13)
                    {
                        a = false;
                    }

                }
                if (x == 6)
                {
                    if (y == 3)
                    {
                        a = false;
                    }
                    if (y == 4)
                    {
                        a = false;
                    }
                    if (y == 5)
                    {
                        a = false;
                    }
                    if (y == 6)
                    {
                        a = false;
                    }

                }
                if (x == 7)
                {
                    if (y == 3)
                    {
                        a = false;
                    }
                    if (y == 4)
                    {
                        a = false;
                    }
                    if (y == 5)
                    {
                        a = false;
                    }
                    if (y == 6)
                    {
                        a = false;
                    }

                }
                if (x == 8)
                {
                    if (y == 3)
                    {
                        a = false;
                    }
                    if (y == 4)
                    {
                        a = false;
                    }
                    if (y == 5)
                    {
                        a = false;
                    }
                    if (y == 6)
                    {
                        a = false;
                    }

                }
                if (x == 9)
                {
                    if (y == 3)
                    {
                        a = false;
                    }
                    if (y == 9)
                    {
                        a = false;
                    }
                    if (y == 10)
                    {
                        a = false;
                    }
                    if (y == 13)
                    {
                        a = false;
                    }

                }
                if (x == 10)
                {
                    if (y == 3)
                    {
                        a = false;
                    }
                    if (y == 5)
                    {
                        a = false;
                    }
                    if (y == 6)
                    {
                        a = false;
                    }
                    if (y == 9)
                    {
                        a = false;
                    }
                    if (y == 10)
                    {
                        a = false;
                    }
                    if (y == 13)
                    {
                        a = false;
                    }

                }
                if (x == 11)
                {
                    if (y == 5)
                    {
                        a = false;
                    }
                    if (y == 6)
                    {
                        a = false;
                    }
                    if (y == 9)
                    {
                        a = false;
                    }
                    if (y == 10)
                    {
                        a = false;
                    }

                }
                if (x == 12)
                {
                    if (y == 3)
                    {
                        a = false;
                    }
                    if (y == 5)
                    {
                        a = false;
                    }
                    if (y == 6)
                    {
                        a = false;
                    }
                    if (y == 9)
                    {
                        a = false;
                    }
                    if (y == 10)
                    {
                        a = false;
                    }

                }
                if (x == 13)
                {
                    if (y == 3)
                    {
                        a = false;
                    }
                    if (y == 5)
                    {
                        a = false;
                    }
                    if (y == 6)
                    {
                        a = false;
                    }
                    if (y == 9)
                    {
                        a = false;
                    }
                    if (y == 10)
                    {
                        a = false;
                    }
                    if (y == 8)
                    {
                        a = false;
                    }

                }
            }
            else
            {
                a = false;
            }
            return a;
        }
    }
}

