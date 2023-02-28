namespace Lesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk();
            Console.WriteLine("Input smetan's count: ");
            int smetanCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Summa of smetan = {milk.MakeSmetan(smetanCount)}");

            Console.WriteLine("Input matzoon's count: ");
            int matzoonCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Summa of matzoon = {milk.MakeMatzoon(matzoonCount)}");

            Console.WriteLine("Input tvarog's count: ");
            int tvarogCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Summa of tvarog = {milk.MakeTvarog(tvarogCount)}");


        }
    }


    public class Milk
    {
        const int SMETAN_PRICE = 250,
        MATZOON_PRICE = 300,
        TVAROG_PRICE = 450;

        public int MakeSmetan(int count)
        {
            return SMETAN_PRICE * count;
        }

        public int MakeMatzoon(int count)
        {
            return MATZOON_PRICE * count;
        }

        public int MakeTvarog(int count)
        {
            return TVAROG_PRICE * count;
        }
    }
}