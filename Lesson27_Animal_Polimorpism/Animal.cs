namespace Lesson27_Animal_Polimorpism
{
    internal class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("Animal's voice");
        }
        public virtual void Speed(int speed)
        {
            Console.WriteLine("Animal's speed is " + speed);
        }
    }
}
