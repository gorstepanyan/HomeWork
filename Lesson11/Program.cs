using System.Data;

namespace Lesson11_Overloading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int[] arr = new int[] { };
            //arr = AddInArray(arr, 5);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine(new string('-', 20));

            ///////////////////////////////////////////////////////////////////////////

            //AddInArray(ref arr, 10);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine(new string('-', 20));

            //////////////////////////////////////////////////////////////////////////

            //int[] arrayForAdd = new int[3] { 12, 13, 14 };
            //arr = AddInArray(arr, arrayForAdd);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine(new string('-', 20));

            ///////////////////////////////////////////////////////////////////////

            //arr = arr.Append(599).ToArray();
            //Array.Resize(ref arr, arr.Length + 1);

            string x = Console.ReadLine();

            DataTable dt = new DataTable();
            Console.WriteLine(dt.Compute(x, ""));


        }

        private static int[] AddInArray(int[] a, int v)
        {
            int[] tmpArr = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                tmpArr[i] = a[i];
            }
            tmpArr[a.Length] = v;
            return tmpArr;
        }

        private static int[] AddInArray(int[] a, int[] v)
        {
            int[] tmpArr = new int[a.Length + v.Length];
            for (int i = 0; i < a.Length; i++)
            {
                tmpArr[i] = a[i];
            }
            for (int i = 0; i < v.Length; i++)
            {
                tmpArr[i + a.Length] = v[i];
            }
            return tmpArr;
        }

        private static void AddInArray(ref int[] a, int v)
        {
            int[] tmpArr = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                tmpArr[i] = a[i];
            }
            tmpArr[a.Length] = v;
            a = tmpArr;
        }


    }

}