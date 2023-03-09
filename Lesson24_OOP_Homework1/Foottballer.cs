namespace Lesson24_OOP_Homework1
{
    internal class Foottballer : Person
    {
        public Foottballer() //: base()
        {
            Console.WriteLine("Creating instance of Footballer without parameters");
            PrintDatas();
        }

        public Foottballer(string name, string surName, string fatherName, GenderEnum gender, int height, Shoes shoes) : base(name, surName, fatherName, gender, height, shoes)
        {
            Console.WriteLine("Creating instance of Footballer by parameters");
            PrintDatas();
        }

        public void Run()
        {
            Console.WriteLine($"Footballer {_name} is running...");
            Console.WriteLine(new string('_', 20));
        }
        public void Gool()
        {
            Console.WriteLine($"Footballer {_name} scores a goal!!!");
            Console.WriteLine(new string('_', 20));
        }
    }
}
