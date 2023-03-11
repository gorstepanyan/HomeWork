namespace Lesson27_Animal_Polimorpism
{
    internal class Cow : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cow say Muuuuuuuuuuuu");
        }
        public override void Speed(int speed)
        {
            Console.WriteLine("Cow's speed is " + speed);
        }
    }
}
