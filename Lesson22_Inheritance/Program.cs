namespace Lesson22_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doctor doctor = new Doctor();
            //doctor.TestMethod();
            //Console.WriteLine(doctor.Age + "Doctor");
            //Console.WriteLine(doctor.Name);
            //HumanBase humanBase = new HumanBase();
            //Console.WriteLine(humanBase.Age + "HumanBase");
            //Console.WriteLine("-------------------------------------------------");
            ////-------------------------------------------------



            //Doctor doctorParam = new Doctor(8);
            //doctorParam.TestMethod();
            //Console.WriteLine(doctorParam.Age + "DoctorParam");
            //Console.WriteLine(doctorParam.Name);
            //HumanBase human = new HumanBase();
            //Console.WriteLine(human.Age);
            //doctorParam.Gender = GenderEnum.Girl;
            //Console.WriteLine(doctorParam.Gender);

            DoctorAssistant assistant = new DoctorAssistant();
            assistant._DoctorAssist();

            //HumanBase humanBaseParam = new HumanBase(9);
            //Console.WriteLine(humanBaseParam.Age + "HumanBase");
            ////-------------------------------------------------


        }
    }
}