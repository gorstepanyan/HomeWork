namespace Lesson21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 1;
            //Rec(num);
            //Console.WriteLine(RecSum(num));

            var myClass = new MyClass();
            Console.WriteLine(myClass.Name);//From Public
            Console.WriteLine(myClass.FoodName);//From Protected Internal
            Console.WriteLine(myClass.Car);//From Internal
        }

        static void Rec(int num)
        {
            if (num > 100)
            {
                return;
            }
            Console.WriteLine(num.ToString());
            Rec(num + 1);
        }

        static int RecSum(int num)
        {
            if (num > 100)
            {
                return 0;
            }
            return num + RecSum(num + 1);
        }
    }
}