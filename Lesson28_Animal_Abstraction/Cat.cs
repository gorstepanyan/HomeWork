namespace Lesson28_Animal_Abstraction
{
    internal class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cat is myauing");
        }
        public override void Speed(int speed)
        {
            Console.WriteLine("Cat's speed is " + speed);
        }
    }
}
