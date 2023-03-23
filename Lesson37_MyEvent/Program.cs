namespace Lesson37_MyEvent
{
    public delegate void KeyPress();

    internal class Program
    {
        static void W_Press()
        {
            Console.WriteLine("\nGo Ahead!!!!");
        }
        static void S_Press()
        {
            Console.WriteLine("\nGo Back!!!!");
        }

        static void Main(string[] args)
        {
            KeyBoardMaster keyBoardMaster = new KeyBoardMaster();
            keyBoardMaster.wPress += W_Press;
            keyBoardMaster.sPress += S_Press;

            ConsoleKey pressedKey;
            bool validKey = true;
            while (validKey)
            {
                pressedKey = Console.ReadKey().Key;
                switch (pressedKey)
                {
                    case ConsoleKey.W:
                        keyBoardMaster.WPress();
                        break;
                    case ConsoleKey.S:
                        keyBoardMaster.SPress();
                        break;
                    case ConsoleKey.Escape:
                        validKey = false;
                        break;
                    default:
                        Console.WriteLine("\nPress a valid key or Escape !!!");
                        break;
                }
            }

        }
    }
}