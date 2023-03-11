namespace Lesson27_Animal_Polimorpism
{
    internal class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cat say Myauuuuuuu");
        }
        public override void Speed(int speed)
        {
            Console.WriteLine("Cat's speed is " + speed);
        }
    }
}
