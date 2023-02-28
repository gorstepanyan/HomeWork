namespace Lesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ErrorTypes validationType = new ErrorTypes();
            Console.Write("Input human's Name: ");
            string name = Console.ReadLine();
            Console.Write("Input human's SurName: ");
            string surName = Console.ReadLine();

            try
            {
                Human human = new Human(name, surName);
                validationType = human.Validation();
                if (validationType == ErrorTypes.OK)
                {
                    Console.WriteLine($"The values of name = '{name}' and surname = '{surName}' are correct!!!");
                    Console.WriteLine(new string('-', 20));

                    Console.Write("Input symbol for count it: ");
                    char chr = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine($"The count of symbol '{chr}' is {human.Check(chr)}");
                    Console.WriteLine(new string('-', 20));
                }
                else
                {
                    throw new Exception(((int)validationType).ToString());
                }
            }
            catch (Exception ex)
            {
                if ((int)validationType is >= 1 and <= 2)
                {
                    Console.WriteLine($"The values of name = '{name}' and surname = '{surName}' aren't correct!!!");
                }
                else
                {
                    validationType = ErrorTypes.SomeThingIsWrong;
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(new string('-', 20));
            }
            finally
            {
                if (validationType == 0)
                {
                    Console.WriteLine("Greate Job!!!");
                }
                else if ((int)validationType is >= 1 and <= 2)
                {

                    Console.WriteLine("You have to input correct datas. Please, try again !!!");
                }
                else
                {
                    Console.WriteLine("Something is wrong !!!");
                }
            }
        }
    }
}