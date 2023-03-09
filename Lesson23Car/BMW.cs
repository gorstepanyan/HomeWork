namespace Lesson23Car
{
    internal class BMW : Car
    {
        public BMW()
        {

        }
        public BMW(int year) : base(year)
        {
            Console.WriteLine($"BMW_CreatedYear: {CreatedYear}");
        }
        public BMW(string color, int createdYear, string winCode) : base(color, createdYear, winCode)
        {
            Console.WriteLine($"BMW-Color: {Color}");
            Console.WriteLine($"BMW-Color: {CreatedYear}");
            Console.WriteLine($"BMW-Color: {WinCode}");
            Console.WriteLine("---------------------------------------------");
        }
    }

    internal class M4 : BMW
    {
        public M4()
        {
        }
        public M4(int year) : base(year)
        {
            Console.WriteLine($"M4_CreatedYear: {CreatedYear}");
        }
        public M4(string color, int createdYear, string winCode, BMWSpecColor specColor) : base(color, createdYear, winCode)
        {
            SpecColor = specColor;
            Console.WriteLine($"M4-Color: {Color}");
            Console.WriteLine($"M4-Color: {CreatedYear}");
            Console.WriteLine($"M4-Color: {WinCode}");
            Console.WriteLine($"M4-Color: {SpecColor}");
            Console.WriteLine("---------------------------------------------");
        }
        public BMWSpecColor SpecColor { get; set; }
    }

    internal enum BMWSpecColor
    {
        Color1,
        Color2,
        Color3
    }

}
