namespace Lesson38_Delegate
{
    public delegate int CountDelegate(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringHelper helper = new StringHelper();
            //CountDelegate d1 = helper.GetCount;
            //CountDelegate d2 = helper.GetCountSymbolA;
            //string testString = "LAMP";
            //Console.WriteLine($"Total count of symbols: {TestDelegate(d1, testString)}");
            //Console.WriteLine($"Count of symbols A: {TestDelegate(d2, testString)}");

            Student student = new Student();
            student.Moving += Student_Moving;
            student.Move(7);
        }

        private static void Student_Moving(string message)
        {
            Console.WriteLine(message);
        }

        //private static void Student_Moving(object? sender, MovingEventArgs e)
        //{
        //    Console.WriteLine(e.Message);
        //}

        //static int TestDelegate(CountDelegate method, string testString)
        //{
        //    return method(testString);
        //}

        static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}