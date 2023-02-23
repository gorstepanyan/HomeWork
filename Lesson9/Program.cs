namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetByRef");
            int x = Convert.ToInt32(Console.ReadLine());
            GetByRef(ref x);
            Console.WriteLine(x);

            Console.WriteLine("GetByOut");
            GetByOut(out int y);
            Console.WriteLine(y);
        }

        static void GetByRef(ref int x)
        {
            x = x * x;
        }
        static void GetByOut(out int x)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            x = a * a;
        }




    }
}