namespace Lesson_33_Event
{
    internal class Person
    {
        public event EventHandler GoToSleep;
        public event EventHandler DoWork;

        public string Name { get; set; }

        public void TakeTime(DateTime timeForSleep)
        {
            if (timeForSleep.Hour <= 8)
            {
                GoToSleep?.Invoke(this, null);
            }
            else
            {
                DoWork?.Invoke(this, null);
            }
        }

    }
}
