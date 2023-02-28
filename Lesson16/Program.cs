namespace Lesson16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.Read());
            string op = Convert.ToString(Console.Read());
            int b = Convert.ToInt32(Console.Read());

            switch (op)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                default:
                    Console.WriteLine("Finish");
                    break;
            }

            Console.ReadLine();

        }

    }
}