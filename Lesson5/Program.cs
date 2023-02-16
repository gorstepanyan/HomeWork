namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder("Hovo", 50);
            //sb.Append("Vazgen");

            //Console.WriteLine(sb);

            //StringBuilder sb2 = new StringBuilder();
            //sb2.Append("Arayik");

            int day = 14;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Free day");
                    break;
            }

        }
    }
}