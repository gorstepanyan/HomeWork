namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //i = i++;
            //i = i++;
            //i = ++i;
            //i = i++;
            //i = i--;
            //i = ++i;

            //Console.WriteLine(i);

            //int[] fib = new int[9];
            //fib[0] = 0;
            //fib[1] = 1;
            //for (int i = 2; i < fib.Length; i++)
            //{

            //    fib[i] = fib[i - 2] + fib[i - 1];

            //}
            //for (int i = 0; i < fib.Length; i++)
            //{
            //    Console.WriteLine(fib[i]);
            //}

            //Console.WriteLine(FibonacciNumber(10));
            //Console.WriteLine(Factorial(4));

            //Matryoshka(7);

            //DrowTriangle(-15, 15, 'H');

            //string path = Console.ReadLine();
            //AllFilesListFromDirectory(path, "dll", 100);

            Step1(EnumGender.Female, "Abrahamyan Nella");
            Step1(EnumGender.Male, "Stepanyan Gor");

            DaysOfWeek(DaysOfWeekEnum.Sunday);
            DaysOfWeek((DaysOfWeekEnum)1);

        }


        static void DaysOfWeek(DaysOfWeekEnum daysOfWeek)
        {
            if (daysOfWeek == DaysOfWeekEnum.Sunday || daysOfWeek == DaysOfWeekEnum.Saturday)
            {
                Console.WriteLine($"{daysOfWeek} is Hollyday");
            }
            else
            {
                Console.WriteLine($"{daysOfWeek} is Workday");
            }
        }




        static void Step1(EnumGender gender, string name)
        {
            if (gender == EnumGender.Male)
            {
                Console.WriteLine($"Mr {name}");
            }
            if (gender == EnumGender.Female)
            {
                Console.WriteLine($"Mrs {name}");
            }
            Console.WriteLine("Welcome Home.");
        }

        //static void AllFilesListFromDirectory(string p, string extension, int topCount)
        //{
        //    if (topCount > 0)
        //    {
        //        string fileExtension = extension.StartsWith('.') == true ? extension : $".{extension}";
        //        string[] fileEntries = Directory.GetFiles(p);
        //        foreach (string f in fileEntries)
        //        {
        //            if (Path.GetExtension(f) == fileExtension)
        //            {
        //                Console.WriteLine($"{Path.GetFileName(f)}");
        //            }
        //        }
        //        string[] directoryEntries = Directory.GetDirectories(p);
        //        foreach (string d in directoryEntries)
        //        {
        //            AllFilesListFromDirectory(d, fileExtension, --topCount);
        //        }
        //    }
        //}

        static void DrowTriangle(int i, int n, char s)
        {
            //if (i != n)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            break;
            //        default:
            //            Console.WriteLine(new string(s, Math.Abs(i)));
            //            DrowTriangle(i + 1, n, s);
            //            Console.WriteLine(new string(s, Math.Abs(i)));
            //            break;
            //    }
            //}

        }


        //static void Matryoshka(int n)
        //{
        //    if (n == 1)
        //    {
        //        Console.WriteLine($"Last Matryoshka = {n}");
        //    }
        //    else
        //    {
        //        //Console.WriteLine($"Matryoshka Top = {n}");
        //        Matryoshka(n - 1);
        //        Console.WriteLine($"Matryoshka Bottom = {n}");
        //    }
        //}

        //static int FibonacciNumber(int number)
        //{
        //    if (number <= 1)
        //    {
        //        return number;
        //    }
        //    else
        //    {
        //        return FibonacciNumber(number - 2) + FibonacciNumber(number - 1);
        //    }

        //}

        //static int Factorial(int number)
        //{
        //    if (number <= 1)
        //    {
        //        return number;
        //    }
        //    else
        //    {
        //        return number * Factorial(number - 1);
        //    }
        //}





    }
}