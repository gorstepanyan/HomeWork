namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine((int)Math.Pow(i, 2) + (int)Math.Pow(i - 1, 2));
            }

        }

        static bool myIf(int number1, int number2)
        {
            return true;
        }

    }
}