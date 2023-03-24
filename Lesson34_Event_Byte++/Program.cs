namespace Lesson39_Event_Byte__
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate myEvent = null;
        public event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }


        public void InvokeEvent()
        {
            myEvent.Invoke();
        }

    }

    internal class Program
    {
        static private void Handler1()
        {
            Console.WriteLine("Handler event 1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Handler event 2");
        }

        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.myEvent += new EventDelegate(Handler1);
            instance.myEvent += Handler2;
            instance.InvokeEvent();
            instance.myEvent -= Handler2;
            instance.InvokeEvent();
            Console.WriteLine("-------------------");

            MyClass instance1 = new MyClass();
            instance1.MyEvent += new EventDelegate(Handler1);
            instance1.MyEvent += Handler2;
            instance1.InvokeEvent();
            instance1.MyEvent -= Handler2;
            instance1.InvokeEvent();

        }
    }
}