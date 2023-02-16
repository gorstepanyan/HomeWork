namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Meth();
            //Meth("test");
            //Meth(85);
            //Meth(74,96);
            //Meth(45,"jkjkjk");
            //int met1 = Meth1(15, 6);
            //Console.WriteLine(met1);
            //double met2 = Meth1(15.9, 6.4);
            //Console.WriteLine(met1);
            //Meth1(15, 6);
            //Meth1(15.9, 6.4);

            string s = "abcdcccc";
            char maxDoublicate = new char();
            int countDoublicate = 0;


            for (int i = 0; i < s.Length; i++)
            {
                int tmpDoublicate = 0;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] == s[i])
                    {
                        tmpDoublicate++;
                    }
                }
                if (tmpDoublicate > countDoublicate)
                {
                    countDoublicate = tmpDoublicate;
                    maxDoublicate = (char)s[i];
                }
            }


            Console.WriteLine(maxDoublicate);
        }

        //public static void Meth1(int t, int a)
        //{
        //    Console.WriteLine(t * a);
        //}

        //public static void Meth1(double t, double a)
        //{
        //    Console.WriteLine(t * a);
        //}

        //public static int Meth()
        //{

        //    return 1;
        //}
        //public static string Meth(string s)
        //{

        //    return "5";
        //}
        //public static int Meth(int t)
        //{

        //    return 1;
        //}
        //public static void Meth(int t, int x)
        //{

        //}
        //public static void Meth(int t, string x)
        //{

        //}





    }
}