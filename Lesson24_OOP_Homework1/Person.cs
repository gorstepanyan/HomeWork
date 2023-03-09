namespace Lesson24_OOP_Homework1
{
    internal class Person
    {
        protected string _name;
        private string _surName;
        private string _fatherName;
        private GenderEnum _gender;
        private int _height;
        private int _shoesSize;

        public Person()
        {
            Console.WriteLine("Creating instance of Person without parameters");
            PrintDatas();
        }
        public Person(string name, string surName, string fatherName, GenderEnum gender, int height, Shoes shoes)
        {
            Console.WriteLine("Creating instance of Person by parameters");
            _name = name;
            _surName = surName;
            _fatherName = fatherName;
            _gender = gender;
            _height = height;
            _shoesSize = shoes.Size;
            PrintDatas();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Console.WriteLine("Initializing _name of Person");
            }
        }
        public string SurName
        {
            get { return _surName; }
            set
            {
                _surName = value;
                Console.WriteLine("Initializing _surName of Person");
            }
        }
        public string FatherName
        {
            get { return _fatherName; }
            set
            {
                _fatherName = value;
                Console.WriteLine("Initializing _fatherName of Person");
            }
        }
        public GenderEnum Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                Console.WriteLine("Initializing _gender of Person");
            }
        }
        public int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                Console.WriteLine("Initializing _height of Person");
            }
        }
        public int ShoesSize
        {
            get { return _shoesSize; }
            set
            {
                _shoesSize = value;
                Console.WriteLine("Initializing _shoesSize of Person");
            }
        }

        public void Run()
        {
            Console.WriteLine($"{_name} is running...");
            Console.WriteLine(new string('_', 20));
        }

        public void PrintDatas()
        {
            Console.WriteLine("Printing Datas");
            Console.WriteLine(String.Format("\t_name: {0}", _name ?? ""));
            Console.WriteLine(String.Format("\t_surName: {0}", _surName ?? ""));
            Console.WriteLine(String.Format("\t_fatherName: {0}", _fatherName ?? ""));
            Console.WriteLine(String.Format("\t_gender: {0}", _gender));
            Console.WriteLine(String.Format("\t_height: {0}", _height));
            Console.WriteLine(String.Format("\t_shoesSize: {0}", _shoesSize));
            Console.WriteLine(new string('_', 20));
        }
    }
}
