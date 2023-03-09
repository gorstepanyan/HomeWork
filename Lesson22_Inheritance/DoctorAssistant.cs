namespace Lesson22_Inheritance
{
    internal class DoctorAssistant : Doctor
    {
        public int AssistantAge { get; set; }
        public void _DoctorAssist()
        {
            Console.WriteLine(Name);
        }
        public DoctorAssistant()
        {

        }
    }
}
