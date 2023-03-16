namespace Lesson28_Animal_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = GetAnimalType(AnimalsEnum.Cow);
            cow.Voice();
            Animal cat = GetAnimalType(AnimalsEnum.Cat);
            cat.Voice();
            Animal dog = GetAnimalType(AnimalsEnum.Dog);
            dog.Voice();

            Animal[] animals = new Animal[] { new Cow(), new Cat(), new Dog() };
            foreach (var animal in animals)
            {
                animal.Speed(new Random().Next(20, 50));
            }
        }

        static Animal GetAnimalType(AnimalsEnum animal)
        {
            switch (animal)
            {
                case AnimalsEnum.Cat:
                    return new Cat();
                case AnimalsEnum.Dog:
                    return new Dog();
                case AnimalsEnum.Cow:
                    return new Cow();
                default:
                    throw new Exception("Unnown animal type");
            }
        }
    }
}