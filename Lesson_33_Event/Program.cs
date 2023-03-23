namespace Lesson_33_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Gor" };
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.ParseExact("23.03.2023 21:13:01", "dd.MM.yyyy HH:mm:ss", null));
            person.TakeTime(DateTime.ParseExact("23.03.2023 04:13:01", "dd.MM.yyyy HH:mm:ss", null));
        }

        private static void Person_DoWork(object? sender, EventArgs e)
        {
            Console.WriteLine($"{((Person)sender).Name} goes to work!");
        }

        private static void Person_GoToSleep(object? sender, EventArgs e)
        {
            Console.WriteLine($"{((Person)sender).Name} goes to sleep!");
        }
    }
}