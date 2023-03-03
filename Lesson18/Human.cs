namespace Lesson18
{
    public class Human
    {
        private string _name;
        private string _surName;


        public Human(string name, string surName)
        {
            _name = name;
            _surName = surName;
        }

        public ErrorTypes Validation()
        {
            if (string.IsNullOrEmpty(_name.Trim()) || !OnlyChar(_name))
            {
                return ErrorTypes.NameNotValid;
            }
            if (string.IsNullOrEmpty(_surName.Trim()) || !OnlyChar(_surName))
            {
                return ErrorTypes.SurNameNotValid;
            }
            return ErrorTypes.OK;
        }

        public int Check(char c)
        {
            int cnt = 0;
            string str = string.Concat(_surName, _name);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        private bool OnlyChar(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }

}

