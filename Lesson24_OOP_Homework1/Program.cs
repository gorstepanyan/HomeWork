namespace Lesson24_OOP_Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Gor";
            person.ShoesSize = 45;
            person.PrintDatas();

            var person1 = new Person("Gor", "Stepanyan", "Edik", GenderEnum.Boy, 162, new Shoes(39));
            person1.Height = 180;
            person1.PrintDatas();
            person1.Run();

            var footballer = new Foottballer();
            footballer.Name = "Ashot";
            footballer.PrintDatas();
            footballer.Run();
            footballer.Gool();


            var footballer1 = new Foottballer("Gor", "Stepanyan", "Edik", GenderEnum.Boy, 162, new Shoes(42));
            footballer1.PrintDatas();
            footballer1.Run();
            footballer1.Gool();

        }
    }
}