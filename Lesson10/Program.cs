namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new
            {
                Name = "Milk",
                Energy = 10
            };
            Console.WriteLine(product);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Energy);

            var eat = new Eat() { Name = "Meet" };

            var product2 = new
            {
                eat.Name,
                Energy = 200
            };
            Console.WriteLine(product2);
            Console.WriteLine(product2.Name);
            Console.WriteLine(product2.Energy);

        }
    }
}