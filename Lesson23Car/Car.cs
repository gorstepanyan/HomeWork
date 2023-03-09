namespace Lesson23Car
{
    internal class Car
    {
        public Car()
        {

        }
        public Car(int year)
        {
            CreatedYear = year;
            Console.WriteLine($"Car_CreatedYear: {CreatedYear}");
        }
        public Car(string color, int createdYear, string winCode)
        {
            Color = color;
            CreatedYear = createdYear;
            WinCode = winCode;
            Console.WriteLine($"BMW-Color: {Color}");
            Console.WriteLine($"BMW-Color: {CreatedYear}");
            Console.WriteLine($"BMW-Color: {WinCode}");
            Console.WriteLine("---------------------------------------------");
        }

        public string Color { get; set; }
        public int CreatedYear { get; set; }
        public string WinCode { get; set; }
    }
}
