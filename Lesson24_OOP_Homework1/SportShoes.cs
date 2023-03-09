namespace Lesson24_OOP_Homework1
{
    internal class SportShoes : Shoes
    {
        private ColorEnum _color;
        public SportShoes() : base()
        {

        }
        public SportShoes(ColorEnum colorEnum)
        {
            _color = colorEnum;
        }
        public SportShoes(int size, ColorEnum colorEnum) : base(size)
        {
            _color = colorEnum;
            _size = size;
        }
    }
}
