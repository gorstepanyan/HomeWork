namespace Lesson27_Animal_Polimorpism
{
    internal class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine($"{GetType().Name} says Myauuuuuuu");
        }
        public override void Speed(int speed)
        {
            Console.WriteLine($"{GetType().Name}at's speed is " + speed);
        }
    }
}
