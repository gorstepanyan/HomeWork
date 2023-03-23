namespace Lesson37_MyEvent
{
    internal class KeyBoardMaster
    {
        public event KeyPress wPress = null;
        public event KeyPress sPress = null;

        public void WPress()
        {
            if (wPress != null)
            {
                wPress.Invoke();
            }
        }

        public void SPress()
        {
            if (sPress != null)
            {
                sPress.Invoke();
            }
        }

    }
}
