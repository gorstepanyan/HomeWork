namespace Lesson31_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isString = false;
            MyClass<string>.Method1("AAA");
            MyClass<int>.Method1(1515);

            MyClass<string>.Method3("BBB", ref isString);
            if (isString)
            {
                MyClass<string>.Method4("BBB");
            }
            isString = false;
            MyClass<int>.Method3(5151, ref isString);
            if (isString)
            {
                MyClass<int>.Method4(5151);
            }
        }
    }

    public class MyClass<T>
    {
        public static T MyProp { get; set; }
        public static void Method1(T MyProp)
        {
            if (MyProp.GetType().Name == "String")
            {
                Method2(MyProp);
            }
        }
        public static void Method2(T MyProp)
        {
            Console.WriteLine($"{MyProp} is String. Good job!!!");
        }

        public static void Method3(T MyProp, ref bool isString)
        {
            if (MyProp.GetType().Name == "String")
            {
                isString = true;
            }
        }
        public static void Method4(T MyProp)
        {
            Console.WriteLine($"{MyProp} is String. Good job!!!");
        }
    }
}