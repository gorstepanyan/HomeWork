namespace Lesson22_Inheritance
{
    internal class HumanBase
    {
        public HumanBase()
        {

        }
        public HumanBase(short age)
        {
            Age = age;
            Console.WriteLine(Age.ToString() + "Human Age");
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }
        public GenderEnum Gender { get; set; }
        private string Test { get; set; }
        //public void publicHelloMen()
        //{
        //    Console.WriteLine("public Barev Mard");
        //}
        //internal void internalByMen()
        //{
        //    Console.WriteLine("internal ByMen");
        //}
        //protected void protectedWhyMen()
        //{
        //    Console.WriteLine("protected WhyMen");
        //}
        //private void _privateWhyMen()
        //{
        //    Console.WriteLine("private WhyMen");
        //}
    }



    public enum GenderEnum
    {
        Boy,
        Girl
    }
}
