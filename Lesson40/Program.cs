namespace Lesson40_SplitMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int searchValue = arr[i];
                int tmpCount = Search(ref arr, searchValue);
                if (tmpCount > maxCount)
                {
                    maxCount = tmpCount;
                }
            }
            Console.WriteLine(maxCount);
        }

        static int Search(ref int[] arr, int searchValue)
        {
            int maxValue = arr.Length;
            int minValue = arr[0];
            int splitValue = 0;
            int count = 0;
            bool iFound = false;
            while (!iFound)
            {
                splitValue = minValue + ((maxValue - minValue) / 2);
                if (searchValue == minValue || searchValue == splitValue || searchValue == maxValue)
                {
                    iFound = true;
                    break;
                }

                if (searchValue <= splitValue)
                {
                    maxValue = splitValue;
                }
                else
                {
                    minValue = splitValue;

                }
                count++;
            }
            return count;
        }
    }
}