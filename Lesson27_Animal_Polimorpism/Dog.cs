﻿namespace Lesson27_Animal_Polimorpism
{
    internal class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Dog says Haffffff");
        }
        public override void Speed(int speed)
        {
            Console.WriteLine("Dog's speed is " + speed);
        }
    }
}
