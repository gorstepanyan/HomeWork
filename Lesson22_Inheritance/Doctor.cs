namespace Lesson22_Inheritance
{
    internal class Doctor : HumanBase
    {
        public short _age;
        public Doctor() : base()
        {

        }
        public Doctor(short age) : base(age)
        {
            _age = age;
        }
        public void TestMethod()
        {
            Name = "Elizaveta Vchaganovna";
            Age = _age;
            //publicHelloMen();
            //internalByMen();
            //protectedWhyMen();
            //_privateWhyMen();
        }
    }
}
