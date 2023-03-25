namespace Lesson41_WindowsForms_Event
{
    public partial class Form1 : Form
    {
        public delegate string MyDelegate(ref string str);
        public event MyDelegate myEvent;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            myEvent += Method1;
            myEvent += Method1;
            myEvent += Method1;
            label1.Text = myEvent.Invoke(ref str);
        }

        public string Method1(ref string str)
        {
            str += "Method1\n";
            return str;
        }
        public string Method2(ref string str)
        {
            str += "Method2\n";
            return str;
        }
        public string Method3(ref string str)
        {
            str += "Method3";
            return str;
        }


    }
}