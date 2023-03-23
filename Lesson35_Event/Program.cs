namespace Lesson35_Event
{
    public delegate void KeyPressEventDelegate();

    public class KeyboardMaster
    {
        public event KeyPressEventDelegate wKeyPressedEvent = null;
        public event KeyPressEventDelegate sKeyPressedEvent = null;
        public void WKeyPressedEvent()
        {
            if (wKeyPressedEvent != null)
            {
                wKeyPressedEvent.Invoke();
            }
        }
        public void SKeyPressedEvent()
        {
            if (sKeyPressedEvent != null)
            {
                sKeyPressedEvent.Invoke();
            }
        }
    }

    internal class Program
    {
        static private void buttonW_Click()
        {
            Console.WriteLine("Go ahead!!!");
        }
        static private void buttonS_Click()
        {
            Console.WriteLine("Go back!!!");
        }

        static void Main(string[] args)
        {
            KeyboardMaster kM = new KeyboardMaster();
            kM.wKeyPressedEvent += buttonW_Click;
            kM.sKeyPressedEvent += buttonS_Click;

            ConsoleKey pressedKey;
            bool a = true;
            while (a)
            {
                pressedKey = Console.ReadKey().Key;
                switch (pressedKey)
                {
                    case ConsoleKey.W:
                        kM.WKeyPressedEvent();
                        break;
                    case ConsoleKey.S:
                        kM.SKeyPressedEvent();
                        break;
                    default:
                        a = false;
                        break;
                }
            }
        }
    }
}