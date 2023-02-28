namespace Lesson17
{
    public static partial class Meat
    {
        private static int _qababCount;
        private static int _shaurmaCount;

        //public  Meat(int defaultCount)
        //{
        //    _qababCount = _shaurmaCount = defaultCount;
        //}

        //public  Meat(int qababCount, int shaurmaCount)
        //{
        //    _qababCount = qababCount;
        //    _shaurmaCount = shaurmaCount;
        //}
        //public  void GetCounts()
        //{
        //    Console.WriteLine($"Count of qabab is {_qababCount}, and shaurmacount is {_shaurmaCount}");
        //}

        public static void GetCounts(int defaultCount)
        {
            _qababCount = _shaurmaCount = defaultCount;
            Console.WriteLine($"Count of qabab is {_qababCount}, and shaurmacount is {_shaurmaCount}");
        }
        public static void GetCounts(int qababCount, int shaurmaCount)
        {
            _qababCount = qababCount;
            _shaurmaCount = shaurmaCount;
            Console.WriteLine($"Count of qabab is {_qababCount}, and shaurmacount is {_shaurmaCount}");
        }


    }
}
