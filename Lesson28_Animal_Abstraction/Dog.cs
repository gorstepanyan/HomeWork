namespace Lesson28_Animal_Abstraction
{
    internal class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Dog is barking");
        }
        public override void Speed(int speed)
        {
            Console.WriteLine("Dog's speed is " + speed);
        }
    }
}
