namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excersise - 21, 22");
            Random r = new Random();
            int maxValue = 0;
            int a = r.Next(1, 99);
            int b = r.Next(1, 99);
            int c = r.Next(1, 99);
            Console.WriteLine($"a = {a}, b={b}, c={c}");

            Console.WriteLine("Maximum - First variant");
            if (a > b && a > c)
            {
                maxValue = a;
            }
            else if (b > c && b > a)
            {
                maxValue = b;
            }
            else
            {
                maxValue = c;
            }

            Console.WriteLine(maxValue);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Maximum - Second variant");
            int[] randomArray = new int[] { a, b, c };
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] > maxValue)
                {
                    maxValue = randomArray[i];
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Minimum - First variant");

            int minValue = 0;
            if (a < b && a < c)
            {
                minValue = a;
            }
            else if (b < c && b < a)
            {
                minValue = b;
            }
            else
            {
                minValue = c;
            }
            Console.WriteLine(minValue);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Minimum - Second variant");
            minValue = randomArray[0];
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] < minValue)
                {
                    minValue = randomArray[i];
                }
            }
            Console.WriteLine(minValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 23 and 33");
            r = new Random();
            a = r.Next(1, 4);
            b = r.Next(1, 4);
            c = r.Next(1, 4);
            int d = r.Next(1, 4);
            Console.WriteLine($"a = {a}, b={b}, c={c}");

            randomArray = new int[] { a, b, c };
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine($"randomArray[{i}] = {(randomArray[i] == 1 ? true : false)}");
                //Console.WriteLine("randomArray[{0}] = {1}", i, randomArray[i] == 1 ? true : false);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Excersise - 24");
            int twoTimeGetTwo = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] == 2)
                {
                    twoTimeGetTwo++;
                }
            }
            Console.WriteLine($"randomArray got number two for two time: {(twoTimeGetTwo == 2 ? true : false)}");
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 25 Bolor 2 tveri gumary piti mec lini 3-rdic ");
            r = new Random();
            a = r.Next(1, 100);
            b = r.Next(1, 100);
            c = r.Next(1, 100);
            Console.WriteLine($"a = {a}, b={b}, c={c}");
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("y = 1");
            }
            else
            {
                Console.WriteLine("y = 2");
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 26");
            r = new Random();
            a = r.Next(1, 10);
            b = r.Next(1, 10);
            c = r.Next(1, 10);
            int getOddNumbers = 2;
            Console.WriteLine($"a = {a}, b={b}, c={c}");
            if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                getOddNumbers = 1;
            }
            Console.WriteLine(getOddNumbers);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 27");
            Console.WriteLine("For true");
            a = 1; b = 4; c = 7;
            Console.WriteLine($"a = {a}, b={b}, c={c}");
            if (b - a == c - b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("For false");
            a = 1; b = 5; c = 2;
            Console.WriteLine($"a = {a}, b={b}, c={c}");
            if (b - a == c - b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 28");
            Console.WriteLine("For true");
            a = 1; b = 5; c = 25;
            Console.WriteLine($"a = {a}, b={b}, c={c}");
            if (b / a == c / b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("For false");
            a = 10; b = 2; c = 27;
            Console.WriteLine($"a = {a}, b={b}, c={c}");
            if (b / a == c / b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 29 Increment");
            r = new Random();
            randomArray = new int[] { r.Next(1, 10), r.Next(1, 10), r.Next(1, 10) };
            Console.WriteLine($"a = {randomArray[0]}, b={randomArray[1]}, c={randomArray[2]}");

            for (int i = 0; i < randomArray.Length; i++)
            {
                for (int j = i + 1; j < randomArray.Length; j++)
                {
                    if (randomArray[i] > randomArray[j])
                    {
                        int temp = randomArray[i];
                        randomArray[i] = randomArray[j];
                        randomArray[j] = temp;
                    }
                }
            }
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine(randomArray[i]);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 30 Decrement");
            r = new Random();
            randomArray = new int[] { r.Next(1, 10), r.Next(1, 10), r.Next(1, 10) };
            Console.WriteLine($"a = {randomArray[0]}, b={randomArray[1]}, c={randomArray[2]}");

            for (int i = 0; i < randomArray.Length; i++)
            {
                for (int j = i + 1; j < randomArray.Length; j++)
                {
                    if (randomArray[i] < randomArray[j])
                    {
                        int temp = randomArray[i];
                        randomArray[i] = randomArray[j];
                        randomArray[j] = temp;
                    }
                }
            }
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine(randomArray[i]);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 31");
            Console.WriteLine("Maximum");
            randomArray = new int[] { r.Next(1, 99), r.Next(1, 99), r.Next(1, 99), r.Next(1, 99) };
            Console.WriteLine($"a = {randomArray[0]}, b={randomArray[1]}, c={randomArray[2]}, d={randomArray[3]}");
            maxValue = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] > maxValue)
                {
                    maxValue = randomArray[i];
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 32");
            Console.WriteLine("Maximum");
            randomArray = new int[] { r.Next(1, 99), r.Next(1, 99), r.Next(1, 99), r.Next(1, 99) };
            Console.WriteLine($"a = {randomArray[0]}, b={randomArray[1]}, c={randomArray[2]}, d={randomArray[3]}");
            maxValue = randomArray[0];
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] < maxValue)
                {
                    maxValue = randomArray[i];
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 34");
            r = new Random();
            a = r.Next(1, 4);
            b = r.Next(1, 4);
            c = r.Next(1, 4);
            d = r.Next(1, 4);
            Console.WriteLine($"a = {a}, b={b}, c={c}, d={d}");
            if (a + b == c + d || a + c == b + d || a + d == b + c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 35");
            r = new Random();
            a = r.Next(1, 6);
            b = r.Next(1, 6);
            c = r.Next(1, 6);
            d = r.Next(1, 6);
            Console.WriteLine($"a = {a}, b={b}, c={c}, d={d}");

            if (a + b + c == d || a + c + d == b || b + c + d == a)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 36");
            r = new Random();
            a = r.Next(1, 10);
            b = r.Next(1, 10);
            c = r.Next(1, 10);
            d = r.Next(1, 10);
            randomArray = new int[] { a, b, c, d };
            int getEvenNumbers = 0;
            Console.WriteLine($"a = {a}, b={b}, c={c}, d={d}");
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 > 0)
                {
                    getEvenNumbers++;
                }
                if (getEvenNumbers == 2)
                {
                    break;
                }
            }
            Console.WriteLine(getEvenNumbers >= 2 ? 2 : 1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 51");
            bool t = false;
            int myNumber = 178;
            Console.WriteLine("myNumber = " + myNumber);
            int hundreds = myNumber / 100,
                tens = myNumber / 10 % 10,
                unit = myNumber % 10;
            if (unit == tens + hundreds)
            {
                t = true;
            }
            Console.WriteLine("unit == hundreds + tens: " + t);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 52");
            t = false;
            myNumber = 177;
            Console.WriteLine("myNumber = " + myNumber);
            hundreds = myNumber / 100;
            tens = myNumber / 10 % 10;
            unit = myNumber % 10;
            if (unit == tens || unit == hundreds || tens == hundreds)
            {
                t = true;
            }
            Console.WriteLine("There're two same numbers: " + t);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 53");
            bool correctN = false;
            int n = 0;
            Console.WriteLine("Input n");
            //n = Convert.ToInt32(Console.ReadLine());
            n = -1;
            if (n != -1)
            {
                while (correctN == false)
                {
                    if (n < 100 || n >= 1000)
                    {
                        Console.WriteLine("Wrong value, please try new n");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        correctN = true;
                    }
                }
                Console.WriteLine("Input k");
                int k1 = Convert.ToInt32(Console.ReadLine());
                a = n % 10; //miavor
                b = n / 10 % 10; // tasnavor
                c = n / 100; //haryuravor
                if (n > k1)
                {
                    Console.WriteLine(n / (a + b + c));
                }
                else
                {
                    Console.WriteLine(n / a);
                }

            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 54, 55");
            correctN = false;
            n = 0;
            Console.WriteLine("Input n");
            //n = Convert.ToInt32(Console.ReadLine());
            n = -1;
            if (n != -1)
            {
                while (correctN == false)
                {
                    if (n < 100 || n >= 1000)
                    {
                        Console.WriteLine("Wrong value, please try new n");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        correctN = true;
                    }
                }
                a = n % 10; //miavor
                b = n / 10 % 10; // tasnavor
                c = n / 100; //haryuravor                
                randomArray = new int[] { a, b, c };
                maxValue = 0;
                minValue = randomArray[0];
                for (int i = 0; i < randomArray.Length; i++)
                {
                    if (randomArray[i] > maxValue)
                    {
                        maxValue = randomArray[i];
                    }
                    if (randomArray[i] < minValue)
                    {
                        minValue = randomArray[i];
                    }
                }

                Console.WriteLine("maxValue = {0}", maxValue);
                Console.WriteLine("minValue = {0}", minValue);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 56");
            correctN = false;
            n = 0;
            Console.WriteLine("Input n");
            //n = Convert.ToInt32(Console.ReadLine());
            n = -1;
            if (n != -1)
            {
                while (correctN == false)
                {
                    if (n < 100 || n >= 1000)
                    {
                        Console.WriteLine("Wrong value, please try new n");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        correctN = true;
                    }
                }
                a = n % 10; //miavor
                b = n / 10 % 10; // tasnavor
                c = n / 100; //haryuravor                
                if (a > b)
                {
                    Console.WriteLine((double)(a + b + c) / n);
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 62");
            correctN = false;
            n = 0;
            Console.WriteLine("Input n");
            //n = Convert.ToInt32(Console.ReadLine());
            n = -1;
            if (n != -1)
            {
                while (correctN == false)
                {
                    if (n < 1000 || n >= 10000)
                    {
                        Console.WriteLine("Wrong value, please try new n");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        correctN = true;
                    }
                }
                a = n % 10; //miavor
                b = n / 10 % 10; // tasnavor
                c = n / 100 % 10; //haryuravor                
                d = n / 1000; //hazaravor
                if (a + c > 0)
                {
                    if (n < 5000)
                    {
                        Console.WriteLine(n / (a + c));
                    }
                    else
                    {
                        Console.WriteLine(n / (d + b));
                    }
                }
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 151, 152, 153, 154");
            int sum = 0,
                product = 1,
                remainderIsTwo = 0,
                remainderIsThree = 0;
            Console.WriteLine("Input n");
            //n = Convert.ToInt32(Console.ReadLine());
            n = -1;
            if (n != -1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i);
                        sum += i;
                        product *= i;
                    }
                    if (n % i == 2)
                    {
                        remainderIsTwo += i;
                    }
                    if (n % i == 3)
                    {
                        remainderIsThree *= i;
                    }

                }
                Console.WriteLine("Summa = {0}", sum);
                Console.WriteLine("Product = {0}", product);
                Console.WriteLine("QuotientIsTwo = {0}", remainderIsTwo);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 155");
            sum = 0;
            for (int i = 10; i <= 99; i++)
            {
                if (i % 3 == 0)
                {
                    //Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 156");
            ulong product1 = 1;
            for (int i = 10; i <= 99; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //Console.WriteLine(i);
                    product1 *= (ulong)i;
                }
            }
            Console.WriteLine(product1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 157");
            sum = 0;
            for (int i = 100; i <= 999; i++)
            {
                if (i % 5 > 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 158");
            product1 = 1;
            for (int i = 100; i <= 999; i++)
            {
                if (i % 2 > 0 && i % 3 > 0)
                {
                    //Console.WriteLine(i);
                    product1 *= (ulong)i;
                }
            }
            Console.WriteLine(product1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 159");
            product1 = 1;
            for (int i = 100; i <= 999; i++)
            {
                if (i % 3 == 1 || i % 4 == 2)
                {
                    product1 *= (ulong)i;
                }
            }
            Console.WriteLine(product1); // TODO value is 0
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 160");
            bool x = false;
            minValue = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    if (i * 16 == Math.Pow(j, 2))
                    {
                        minValue = i;
                        x = true;
                        break;
                    }
                }
                if (x == true)
                {
                    break;
                }
            }
            Console.WriteLine(minValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 161");
            x = false;
            minValue = 0;
            for (int i = 1000; i < 10000; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    if (i * 26 != Math.Pow(j, 2))
                    {
                        minValue = i;
                        x = true;
                        break;
                    }
                }
                if (x == true)
                {
                    break;
                }
            }
            Console.WriteLine(minValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 163");
            x = false;
            maxValue = 0;
            for (int i = 9999; i >= 1000; i--)
            {
                for (int j = 1; j <= 9999; j++)
                {
                    if (i * 18 == (int)Math.Pow(j, 2))
                    {
                        maxValue = i;
                        x = true;
                        break;
                    }
                }
                if (x == true)
                {
                    break;
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 164");
            n = 10;
            for (int i = 100; i < 1000; i++)
            {
                if (Math.Sqrt(i) > n)
                {
                    sum = i;
                    break;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 165");
            a = 1;
            t = false;
            Console.WriteLine("Input n");
            //n = Convert.ToInt32(Console.ReadLine());
            n = -1;
            if (n != -1)
            {
                for (int i = 0; i < n; i++)
                {
                    a *= 3;
                    if (a == n)
                    {
                        t = true;
                        break;
                    }
                }
                Console.WriteLine(t);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 166");
            a = 1;
            int y = 0;
            Console.WriteLine("Input n");
            //n = Convert.ToInt32(Console.ReadLine());
            n = -1;
            if (n != -1)
            {
                for (int i = 0; i < n; i++)
                {
                    a *= 4;
                    if (a == n)
                    {
                        y = 1;
                        break;
                    }
                }
                Console.WriteLine(y);
                Console.WriteLine(new string('-', 20));
                Console.WriteLine(new string('-', 20));
            }


            Console.WriteLine("Excersise - 211");
            int[] arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum / count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 212");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            double sum1 = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum1 += Math.Pow(arr[i], 2);
                    count++;
                }
            }
            Console.WriteLine(sum1 / count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 213"); //TODO
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            sum1 = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sum1 += Math.Pow(arr[i], 2);
                    count++;
                }
            }
            Console.WriteLine(Math.Sqrt(sum1 / count));
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 214");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            sum = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum / count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 215");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            sum = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 216");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            sum = 1;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum *= arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 217");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            sum1 = 1;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum1 *= Math.Pow(arr[i], 2);
                    count++;
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 218");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            sum = 1;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum *= Math.Abs(arr[i]);
                    count++;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 219");
            arr = new int[] { 5, 9, 27, 45, 15, 5, 2, 4 };
            int k = 3;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % k == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));



            Console.WriteLine("Excersise - 220");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            int countPositive = 0;
            int countNegative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    countPositive++;
                }
                if (arr[i] < 0)
                {
                    countNegative++;
                }
            }
            Console.WriteLine("countPositive = " + countPositive);
            Console.WriteLine("countNegative = " + countNegative);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 221, 223");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            a = -3;
            b = 5;
            sum = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= a && arr[i] <= b)
                {
                    sum += arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 222");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            c = 1;
            d = 7;
            product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= c && arr[i] <= d)
                {
                    product *= arr[i];
                }
            }
            Console.WriteLine(product);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 224");
            arr = new int[] { 5, 9, 27, 45, 15, 5, 2, 4 };
            k = 5;
            sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) < k)
                {
                    sum1 += Math.Pow(arr[i], 3);
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 225, 226");
            arr = new int[] { 5, 9, 7, 4, 1, -5, -2, -4 };
            k = 6;
            sum1 = 1;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) < k)
                {
                    sum1 *= arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 227");
            arr = new int[] { 5, 9, 27, 45, 15, 5, 2, 4 };
            k = 6;
            double sum2 = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0) { continue; }
                if (k % i == 0)
                {
                    sum2 += arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum2 / count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 228");
            arr = new int[] { 5, 9, 27, 45, 15, 5, 2, 4 };
            k = 6;
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % k == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 229");
            arr = new int[] { 5, 9, 27, 45, 15, 5, 2, 4 };
            sum = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - i > 0)
                {
                    sum *= arr[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 230");
            double[] arr1 = new double[] { 5.15, 9.56, 12.45, 45.54, 36.85, 5.18, 2.56, 4.14 };
            k = 6;
            sum1 = 1;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr1[i] % k == 0)
                {
                    sum1 += Math.Pow(arr1[i], 2);
                    count++;
                }
            }
            Console.WriteLine(Math.Sqrt(sum1 / count));
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 231, 232");
            arr = new int[] { 5, 9, 28, 45, 15, 5, 2, 4 };
            sum1 = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum1 += Math.Pow(arr[i], 2);
                    count++;
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 233");
            arr = new int[] { 5, 9, 28, 45, 15, 5, 2, 4 };
            sum = 0;
            sum1 = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum1 *= arr[i];
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 234, 235");
            arr = new int[] { 5, 9, 28, 45, 15, 5, 2, 4 };
            sum = 0;
            sum1 = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 > 0)
                {
                    sum += arr[i];
                    sum1 *= Math.Pow(arr[i], 2);
                    count++;
                }
            }
            Console.WriteLine(sum / count);
            Console.WriteLine(Math.Sqrt(sum1 / count));
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 236");
            arr = new int[] { 5, 9, 28, 45, 15, 5, 2, 4 };
            sum1 = 1;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 > 0)
                {
                    sum1 *= arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 238");
            arr = new int[] { 5, 9, 28, 45, 15, 6, 2, 4 };
            sum = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            Console.WriteLine(sum / count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 239");
            arr = new int[] { 5, 9, 28, 45, 15, 6, 2, 4 };
            sum1 = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0)
                {
                    sum1 *= Math.Pow(arr[i], 2);
                    count++;
                }
            }
            Console.WriteLine(sum1 / count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 240");
            arr = new int[] { 5, 9, 28, 45, 15, 6, 2, 4 };
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 241,242,243");
            arr = new int[] { 5, 9, 28, 45, 14, 6, 2, 7 };
            sum = 0;
            sum1 = 1;
            k = 7;
            int m = 5;
            int tt = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % k == 0)
                {
                    sum += arr[i];
                }
                if (arr[i] % m == 0)
                {
                    sum1 *= arr[i];
                }
                if (arr[i] % tt == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum1);
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 244");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 2)
                {
                    product *= arr[i];
                }
            }
            Console.WriteLine(product);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 245");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            sum1 = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] + i) % 3 == 0)
                {
                    sum1 += Math.Pow(arr[i], 2);
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 246"); //TODO
            arr = new int[] { 515, 98, 27, 456, 150, 6889, 24, 515, 98, 27, 456, 150, 6889, 24, 515, 98, 27, 456, 150, 6889, 24, 515, 98, 27, 456, 150, 6889, 24, 485 };
            sum = 0;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < 2000; j++)
                {
                    if (Math.Pow(j, 2) == i)
                    {
                        sum += arr[i];
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine(count > 0 ? sum / count : 0);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 247");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            sum1 = 1;
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > i)
                {
                    sum1 += Math.Pow(arr[i], 2);
                    count++;
                }
            }
            Console.WriteLine(sum1 / count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 248");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            sum = 0;
            k = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Pow(arr[i] + i, 2) % k == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 249");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            count = 0;
            k = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - i) > k)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 250");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            double product2 = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] * i % 3 == 2)
                {
                    product2 *= Math.Pow(arr[i], 2);
                }
            }
            Console.WriteLine(product2);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 251");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            maxValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 252");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine(minValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 253, 254");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            maxValue = 0;
            minValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine(minValue + maxValue);
            Console.WriteLine(minValue * maxValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 255");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            maxValue = 0;
            int indexMaxValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    indexMaxValue = i;
                }
            }
            Console.WriteLine(maxValue + indexMaxValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 256");
            arr = new int[] { 5, 9, 27, 45, 15, 6, 2, 4 };
            minValue = arr[0];
            int indexMinValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    indexMinValue = i;
                }
            }
            Console.WriteLine(minValue + indexMinValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 257");
            arr = new int[] { 5, 9, 27, 27, 15, 6, 27, 4 };
            maxValue = 0;
            indexMaxValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    indexMaxValue = i;
                }
            }
            Console.WriteLine(indexMaxValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 258");
            arr = new int[] { 5, 9, 27, 27, 15, 6, 27, 4 };
            maxValue = 0;
            indexMaxValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= maxValue)
                {
                    maxValue = arr[i];
                    indexMaxValue = i;
                }
            }
            Console.WriteLine(indexMaxValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 259");
            arr = new int[] { 5, 9, 2, 45, 2, 6, 2, 4 };
            minValue = arr[0];
            indexMinValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    indexMinValue = i;
                }
            }
            Console.WriteLine(indexMinValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 260");
            arr = new int[] { 5, 9, 2, 45, 2, 6, 2, 4 };
            minValue = arr[0];
            indexMinValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= minValue)
                {
                    minValue = arr[i];
                    indexMinValue = i;
                }
            }
            Console.WriteLine(indexMinValue);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));


            Console.WriteLine("Excersise - 261");
            int[] X = new int[] { 5, 9, 27, 45, 82, 65, 12, 4 };
            int[] Y = new int[] { 5, 9, 27, 45, 82, 65, 12, 4, 62, 99 };
            int sumX = 0,
                sumY = 0;
            for (int i = 0; i < X.Length; i++)
            {
                sumX += X[i];
            }
            for (int i = 0; i < Y.Length; i++)
            {
                sumY += Y[i];
            }
            Console.WriteLine(sumX / X.Length + sumY / Y.Length);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Excersise - 262");
            X = new int[] { 5, 9, 27, 45, 82, 65, 12, 4 };
            Y = new int[] { 5, 9, 27, 45, 82, 65, 12, 4, 62, 99 };
            double sum1X = 0,
                sum1Y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                sum1X += Math.Pow(X[i], 2);
            }
            for (int i = 0; i < Y.Length; i++)
            {
                sum1Y += Math.Pow(Y[i], 2);
            }
            Console.WriteLine(sum1X / X.Length + sum1Y / Y.Length);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 263");
            X = new int[] { 5, 9, 27, -45, 82, 65, 12, -4 };
            Y = new int[] { 5, -9, 27, 45, 82, -65, 12, 4, -62, 99 };
            sum = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] > 0)
                {
                    sum += X[i];
                }
            }
            for (int i = 0; i < Y.Length; i++)
            {
                if (Y[i] > 0)
                {
                    sum += Y[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 264");
            X = new int[] { 5, 9, 27, -45, 82, 65, 12, -4 };
            Y = new int[] { 5, -9, 27, 45, 82, -65, 12, 4, -62, 99 };
            sum = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] < 0)
                {
                    sum += X[i];
                }
            }
            for (int i = 0; i < Y.Length; i++)
            {
                if (Y[i] < 0)
                {
                    sum += Y[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 265");
            X = new int[] { 5, 9, 27, 45, 82, 65, 12, 4 };
            Y = new int[] { 5, 9, 27, 45, 82, 65, 12, 4, 62, 99 };
            double sumDouble = 0;
            double productDouble = 1;
            for (int i = 0; i < X.Length; i++)
            {
                sumDouble += X[i];
            }
            for (int i = 0; i < Y.Length; i++)
            {
                productDouble *= Y[i];
            }
            Console.WriteLine(sumDouble / productDouble);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 266");
            X = new int[] { 5, 9, 27, 45, 82, 65, 12, 4 };
            Y = new int[] { 5, 9, 27, 45, 82, 65, 12, 4, 62, 99 };
            sumX = 0;
            sumY = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 > 0)
                {
                    sumX += X[i];
                }
            }
            for (int i = 0; i < Y.Length; i++)
            {
                if (Y[i] % 2 == 0)
                {
                    sumY += Y[i];
                }
            }
            Console.WriteLine(sumX - sumY);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 267, 268");
            X = new int[] { 5, 9, 24, 45, 82, 65, 14, 4 };
            Y = new int[] { 5, 9, 27, 45, 70, 63, 12, 4, 62, 99 };
            sum = 0;
            k = 7;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % k == 0)
                {
                    sum += X[i];
                }
            }
            for (int i = 0; i < Y.Length; i++)
            {
                if (Y[i] % k == 0)
                {
                    sum += Y[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 269");
            X = new int[] { 5, 9, 24, 45, 82, 65, 14, 4 };
            Y = new int[] { 5, 9, 27, 45, 70, 63, 12, 4, 62, 99 };
            sum = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    sum += X[i];
                }
            }
            for (int i = 0; i < Y.Length; i++)
            {
                if (Y[i] % 2 > 0)
                {
                    sum += Y[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 270");
            X = new int[] { 5, 9, 24, 45, 82, 65, 14, 4 };
            Y = new int[] { 5, 9, 27, 45, 70, 63, 12, 4, 62, 99 };
            sum1 = 0;
            for (int i = 0; i < X.Length; i++)
            {
                sum1 += Math.Pow(X[i], 2);
            }
            for (int i = 0; i < Y.Length; i++)
            {
                sum1 += Math.Pow(Y[i], 2);
            }
            Console.WriteLine(sum1);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 271");
            n = 7;
            char[] charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 'd';
            charArray[4] = 'a';
            charArray[5] = 'b';
            charArray[6] = 'e';
            count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 272");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 'b';
            charArray[4] = 'b';
            charArray[5] = 'b';
            charArray[6] = 'e';
            charArray[7] = 'a';
            t = false;
            count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'b')
                {
                    count++;
                }
            }
            if (count >= n / 2)
            {
                t = true;
            }
            Console.WriteLine(t);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 273");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 's';
            charArray[4] = 'b';
            charArray[5] = 's';
            charArray[6] = 'e';
            charArray[7] = 's';
            sum = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 's')
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 274");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 's';
            charArray[4] = 'b';
            charArray[5] = 's';
            charArray[6] = 'e';
            charArray[7] = 's';
            sum = 0;
            count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] > 'h')
                {
                    sum += i;
                    count++;
                }
            }
            Console.WriteLine(sum / count);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 275");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 's';
            charArray[4] = 'q';
            charArray[5] = 's';
            charArray[6] = 'e';
            charArray[7] = 's';
            count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] < 'k')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 276");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 's';
            charArray[4] = 'r';
            charArray[5] = 's';
            charArray[6] = 'e';
            charArray[7] = 's';
            t = false;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'r')
                {
                    t = true;
                    break;
                }
            }
            Console.WriteLine(t);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 277");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 'd';
            charArray[4] = 'r';
            charArray[5] = 's';
            charArray[6] = 'e';
            charArray[7] = 'd';
            count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != 'd')
                {
                    count++;
                }
            }
            char[] charArray1 = new char[count];
            int charArray1Index = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != 'd')
                {
                    charArray1[charArray1Index] = charArray[i];
                    charArray1Index++;
                }
            }

            Console.WriteLine(charArray1);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 278");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 'd';
            charArray[4] = 'r';
            charArray[5] = 's';
            charArray[6] = 'e';
            charArray[7] = 'd';
            count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i % 2 > 0)
                {
                    count++;
                }
            }
            charArray1 = new char[count];
            charArray1Index = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i % 2 > 0)
                {
                    charArray1[charArray1Index] = charArray[i];
                    charArray1Index++;
                }
            }
            Console.WriteLine(charArray1);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 279");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 'd';
            charArray[4] = 'r';
            charArray[5] = 's';
            charArray[6] = 'e';
            charArray[7] = 'd';
            count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] > 'k')
                {
                    count++;
                }
            }
            charArray1 = new char[count];
            charArray1Index = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] > 'k')
                {
                    charArray1[charArray1Index] = charArray[i];
                    charArray1Index++;
                }
            }
            Console.WriteLine(charArray1);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 280");
            n = 8;
            charArray = new char[n];
            charArray[0] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 'f';
            charArray[4] = 'r';
            charArray[5] = 'f';
            charArray[6] = 'e';
            charArray[7] = 'd';
            count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'f')
                {
                    count++;
                }
            }
            count += charArray.Length;
            charArray1 = new char[count];
            charArray1Index = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray1[charArray1Index++] = charArray[i];
                if (charArray[i] == 'f')
                {
                    charArray1[charArray1Index++] = charArray[i];
                }
            }
            Console.WriteLine(charArray1);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 281 -> 310"); // TODO vectors
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 333");
            n = 8;
            int[] intArray = new int[n];
            intArray[0] = 2;
            intArray[1] = 15;
            intArray[2] = 84;
            intArray[3] = 1;
            intArray[4] = 5;
            intArray[5] = 4;
            intArray[6] = 3;
            intArray[7] = 98;
            k = 8;
            for (int i = 1; i < intArray.Length - 1; i++)
            {
                if (intArray[i - 1] + intArray[i + 1] < k)
                {
                    Console.WriteLine(intArray[i]);
                }
            }
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 335");
            n = 8;
            intArray = new int[n];
            intArray[0] = 2;
            intArray[1] = 15;
            intArray[2] = 84;
            intArray[3] = 1;
            intArray[4] = 5;
            intArray[5] = 4;
            intArray[6] = 3;
            intArray[7] = 98;
            maxValue = 0;
            for (int i = 1; i < intArray.Length - 1; i++)
            {
                if (intArray[i - 1] + intArray[i + 1] > maxValue)
                {
                    maxValue = intArray[i];
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 336");
            arr = new int[] { 5, 9, 24, 45, -2, 65, 14, 4 };
            bool hasNegativValue = false;
            maxValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    hasNegativValue = true;
                }
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            Console.WriteLine("s = {0}", hasNegativValue == true ? maxValue : 0);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 337");
            arr = new int[] { 5, 9, 24, -45, -2, 65, -14, 4 };
            sum = 0;
            product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    product *= arr[i];
                }
                if (i % 2 > 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("s = {0}", product > 0 ? sum : 1);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 338");
            arr = new int[] { 5, 65, 24, 65, 2, 65, 14, 4 };
            maxValue = 0;
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    sum = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] > maxValue)
                        {
                            sum = 0;
                            break;
                        }
                        if (arr[j] == maxValue)
                        {
                            sum += i;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 339");
            arr = new int[] { 5, 65, 24, 65, 2, 6, 14, 4, 24, 64, 3 };
            maxValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 3 == 0 && arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 340");
            arr = new int[] { 5, 65, 24, 65, 2, 5, 14, 4, 24, 65, 3 };
            minValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 5 == 2 && arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine(minValue);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 341");
            arr = new int[] { 5, 65, 24, 56, 52, 25, 2, 4, 42, 61, 3 };
            t = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        t = false;
                        break;
                    }
                }
                if (t == false) { break; }
            }
            Console.WriteLine(t);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));

            Console.WriteLine("Excersise - 342");
            arr = new int[] { 5, 3, 10, 3, 52, 25, 24, 5, 10, 61, 3 };
            sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp1;
                    }
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] == arr[i] || arr[i - 1] == arr[i])
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


            Console.WriteLine("Excersise - 343");
            arr1 = new double[] { 5, 36, 10, 3, 0.2, 25, 24, 5, 81, 0.1, 93 };
            sum1 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[j] == 1 / arr1[i])
                    {
                        sum1 += arr1[i];
                        break;
                    }
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine(new string('-', 20) + '\n' + new string('-', 20));


        }
    }
}