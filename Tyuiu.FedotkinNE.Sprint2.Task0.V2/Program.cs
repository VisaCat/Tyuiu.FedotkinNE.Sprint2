namespace Tyuiu.FedotkinNE.Sprint2.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
            int y = 123;

            bool[] result = new bool[6];

            result[0] = x == y + 1; // False
            result[1] = x * y > 10000; // True
            result[2] = x / y <= 1; // False
            result[3] = x - y >= 0; // True
            result[4] = x != y * 2; // False
            result[5] = x + y > 200; // True

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
