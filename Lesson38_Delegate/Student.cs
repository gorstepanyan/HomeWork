namespace Lesson38_Delegate
{
    internal class Student
    {
        public void Move(int distance)
        {
            if (Moving != null)
            {
                for (int i = 1; i <= distance; i++)
                {
                    Thread.Sleep(1000);
                    Moving($"It's moving... done {i} kilometers");
                }
            }
        }

        //public Action<string> Moving { get; set; }
        //public event EventHandler<MovingEventArgs> Moving;
        public Action<string> Moving;

    }
}
