namespace Lesson17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Meat meat = new Meat(5, 3);
            //meat.GetCounts();
            //Meat meat1 = new Meat(5);
            //meat1.GetCounts();
            Meat.GetCounts(5);
            Meat.GetCounts(10, 6);
            Meat.PrintPartial();
        }
    }





}