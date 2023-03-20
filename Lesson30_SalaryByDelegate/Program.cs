namespace Lesson30_Delegate
{
    internal class Program
    {
        static void Main()
        {
            Account account = new Account(200);
            account.RegisterHandler(PrintSimpleMessage);
            account.RegisterHandler(PrintColorMessage);
            //account.UnRegisterHandler(PrintSimpleMessage);
            account.Taken(100);
            account.Taken(150);

            account.UnRegisterHandler(PrintColorMessage);
            account.Taken(50);
        }

        static void PrintSimpleMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void PrintColorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}