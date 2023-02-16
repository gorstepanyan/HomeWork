namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input number");
            //int t = int.Parse(Console.ReadLine());
            //Console.WriteLine("start readline number");
            //Calc(t);
            //Console.WriteLine("Start 885");
            //Calc(855);

            Console.WriteLine("Input N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Avg(n));

        }

        static double Avg(double t)
        {
            int sum = 0;
            int count = 0;

            for (int i = 1; i <= t; i++)
            {
                sum = sum + i;
                count++;
            }
            return sum / count;
        }
        static double Calc(int tt)
        {
            int sum = 0;
            for (int i = 0; i <= tt; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}