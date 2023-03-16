namespace Lesson28_Animal_Abstraction
{
    internal abstract class Animal
    {
        public abstract void Voice();
        public virtual void Speed(int speed)
        {
            Console.WriteLine("Animal's speed is " + speed);
        }
    }
}
