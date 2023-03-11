namespace Lesson26_Polimorphism
{
    internal class VirtualClass
    {
        public virtual string Name { get; set; }
        public virtual void NormalMethod()
        {
            Console.WriteLine("Normal Method");
        }
        public virtual int VirtualMethod(int y)
        {
            Console.WriteLine("Virtual Method" + y);
            return y;
        }
        public virtual void VirtualVoidMethod()
        {
            Console.WriteLine("Virtual Void Method");
        }
        public virtual void VirtualEmptyMethod()
        {
        }



    }
}
