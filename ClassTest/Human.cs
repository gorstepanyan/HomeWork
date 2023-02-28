namespace ClassTest
{
    internal class Human
    {
        public int MyProperty { get; set; }

        public int HumanMonth(int age)
        {

            const byte month = 12;
            return age * month;
        }

        readonly short day = 365;
        public int HumanDay(int age)
        {
            return age * day;
        }
    }
}
