namespace Lesson8
{
    internal class Program
    {
        delegate void MessageHandler(string str);
        static void Main(string[] args)
        {
            //MessageHandler handler = delegate (string str   )
            //{
            //    Console.WriteLine(str);
            //};
            //handler("Hello");
            //Show("Hello World", delegate (string m)
            //{
            //    Console.WriteLine(m);
            //});

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            double input2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Add(input1, input2);
                        break;
                    }
                case 2:
                    {
                        result = Sub(input1, input2);
                        break;
                    }
                case 3:
                    {
                        result = Mult(input1, input2);
                        break;
                    }
                case 4:
                    {
                        result = Div(input1, input2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }


        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }


    }
}