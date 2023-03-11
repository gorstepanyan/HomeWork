namespace Lesson26_Polimorphism
{
    internal class TestClass : VirtualClass
    {
        public TestClass() { }
        public TestClass(int t)
        {
            base.VirtualMethod(t);
        }
        public override void VirtualEmptyMethod()
        {
            Console.WriteLine("TestClass: VirtualClass");
            base.VirtualEmptyMethod();
            Console.WriteLine("Ending VirtualEmptyMethod");
        }
        public override int VirtualMethod(int u)
        {
            return base.VirtualMethod(u);
        }
    }
}
