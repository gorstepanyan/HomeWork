namespace Lesson28_Animal_Abstraction
{
    internal class Cow : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cow is muuuuuing");
        }
        public override void Speed(int speed)
        {
            base.Speed(new Random().Next(15, 56));
            Console.WriteLine("Cow's speed is " + speed);
        }
    }
}
