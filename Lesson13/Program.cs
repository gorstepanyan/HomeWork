namespace Lesson13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Calc.Add(5, 5));

            Console.WriteLine(Person.havToLive);

            var instance = new
            {
                FirstName = "Jamie",
                LastName = "King",
                Age = 12,
                GPA = 4.0
            };
            Console.WriteLine(instance.LastName);


        }

        public static class Calc
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
            public static int Sub(int a, int b)
            {
                return a - b;
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDay { get; set; }

            public int GetAge()
            {
                return DateTime.Now.AddYears(-BirthDay.Year).Year;
            }

            public static int havToLive = 54;
        }

    }
}