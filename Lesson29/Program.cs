using Lesson29.Classes;
using Lesson29.Interfaces;

namespace Lesson29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            IOrder myOrder = new MyOrder(weight);
        }



    }
}