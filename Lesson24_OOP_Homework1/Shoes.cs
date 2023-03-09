namespace Lesson24_OOP_Homework1
{
    internal class Shoes
    {
        protected int _size;
        public Shoes()
        {

        }
        public Shoes(int size)
        {
            _size = size;
        }
        public int Size { get { return _size; } set { _size = value; } }
    }
}
