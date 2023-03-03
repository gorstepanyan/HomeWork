namespace Lesson19
{
    internal class Restaurant
    {
        private int _sushiCount;
        private int _hotDogCount;
        private int _burgerCount;

        public Restaurant()
        {

        }
        public Restaurant(int sushiCount, int hotDogCount, int burgerCount)
        {
            _sushiCount = sushiCount;
            _hotDogCount = hotDogCount;
            _burgerCount = burgerCount;
            Reserve();
            if (_sushiCount > 0)
            {
                MakeSushi(in _sushiCount);
            }
            if (_hotDogCount > 0)
            {
                MakeHotDog(in _hotDogCount);
            }
            if (_burgerCount > 0)
            {
                MakeBurger(in _burgerCount);
            }

        }

        private void Reserve()
        {
            if (_sushiCount > 0)
            {
                Console.WriteLine($"Reserved {_sushiCount} sushi");
            }
            if (_hotDogCount > 0)
            {
                Console.WriteLine($"Reserved {_hotDogCount} sushi");
            }
            if (_burgerCount > 0)
            {
                Console.WriteLine($"Reserved {_burgerCount} sushi");
            }
        }

        public void MakeSushi(in int cnt)
        {
            Console.WriteLine($"Making {cnt} sushi");
        }
        public void MakeHotDog(in int cnt)
        {
            Console.WriteLine($"Making {cnt} hotdog");
        }
        public void MakeBurger(in int cnt)
        {
            Console.WriteLine($"Making {cnt} burger");
        }




    }
}
