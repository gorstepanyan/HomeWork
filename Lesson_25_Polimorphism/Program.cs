namespace Lesson25_Polimorphism_Dynamic_Static
{
    #region Dynamic Polimorphism Classes
    internal class Univesity
    {
        protected double UId;
        protected string UName;

        public virtual void Show()
        {
            Console.WriteLine("University ID = " + UId);
            Console.WriteLine("University Name = " + UName);
        }
    }

    internal class Department : Univesity
    {
        protected double DId;
        protected string DName;

        public Department(double UidInput, string UNameInput, double DidInput, string DNameInput)
        {
            DId = DidInput;
            DName = DNameInput;
            base.UId = UidInput;
            base.UName = UNameInput;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Department ID = " + DId);
            Console.WriteLine("Department Name = " + DName);
        }

    }
    #endregion

    #region Static Polimorphism Classes
    public class Parent
    {
        public void Multiplication(double input1, double input2)
        {
            Console.WriteLine("Method with double Parameters is called");
            Console.WriteLine("Result = " + (input1 * input2));
        }
    }

    internal class Program : Parent
    {

        public void Multiplication(int input1, int input2)
        {
            Console.WriteLine("Method with integer Parameters is called");
            Console.WriteLine("Result = " + (input1 * input2));
        }

        static void Main(string[] args)
        {
            #region Dynamic
            Department dp = new Department(138, "Standford", 55, "Computer Science");
            dp.Show();
            #endregion

            Program p = new Program();
            p.Multiplication(10, 3);
            p.Multiplication(10.5, 3);
        }
    }
    #endregion
}