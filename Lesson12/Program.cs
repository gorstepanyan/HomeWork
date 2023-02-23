namespace Lesson12
{
    internal class Program
    {
        public const int MAX_SALARY_VALUE = 1125000;
        private static void Main(string[] args)
        {
            byte salaryType;
            do
            {
                Console.Write("What type of salary do you need to get? 1 - NetSalary, 2 - BasicSalary: ");
                salaryType = Convert.ToByte(Console.ReadLine());
                if (salaryType < 1 || salaryType > 2)
                {
                    Console.WriteLine("The input value is not correct. Please, try again !!!");
                }
            }
            while (salaryType < 1 || salaryType > 2);
            CalculateSalary(salaryType);
        }

        private static void CalculateSalary(byte salaryType)
        {
            byte socValue,
                incomeTaxPercent = (byte)EnumPercents.IncomeTax;
            int itSphereValueResult = 0,
                salaryResult = 0,
                socValueResult = 0;

            Console.Write("Please, enter your {0} salary: ", salaryType == 1 ? "basic" : "net");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Is your company in IT sphere? 1-Yes, 0-No: ");
            byte isItSphere = Convert.ToByte(Console.ReadLine());
            if (isItSphere == 1) { incomeTaxPercent /= 2; }

            Console.Write("Do you participate in a mandatory funded pension scheme? 1-Yes, 0-No: ");
            byte isSoc = Convert.ToByte(Console.ReadLine());

            if (isSoc == 1)
            {
                do
                {
                    Console.Write("On what basis do you participate?\n\t1 - Mandatory or before 07/2018, 2 - Voluntary after 07/2018 : ");
                    socValue = Convert.ToByte(Console.ReadLine());
                    if (socValue < 1 || socValue > 2)
                    {
                        Console.WriteLine("The input value is not correct. Please, try again !!!");
                    }
                }
                while (socValue < 1 || socValue > 2);

                if (salaryType == 1)
                {
                    CalculateSoc1(in salary, in socValue, ref socValueResult);
                }
                else
                {
                    CalculateSoc2(in salary, in socValue, ref socValueResult);
                }

            }

            CalculateStamp(in salary, out int stampPayValue);

            if (salaryType == 1)
            {
                CalculateSalary1(in salary, in incomeTaxPercent, in itSphereValueResult, in socValueResult, in stampPayValue, ref salaryResult);
            }
            else
            {
                CalculateSalary2(in salary, in incomeTaxPercent, in itSphereValueResult, in socValueResult, in stampPayValue, ref salaryResult);
            }

            Console.WriteLine("Your {0} salary is : {1}", salaryType == 1 ? "net" : "basic", salaryResult);
        }




        private static void CalculateSoc1(in int salary, in byte socValue, ref int socValueRresult)
        {
            switch (socValue)
            {
                case 1:
                    if (salary > MAX_SALARY_VALUE)
                    {
                        socValueRresult = 87500;
                    }
                    else
                    {
                        if (salary <= 500000)
                        {
                            socValueRresult = 5 * salary / 100;
                        }
                        else
                        {
                            socValueRresult = (10 * salary / 100) - 25000;
                        }
                    }
                    break;
                case 2:
                    if (salary > MAX_SALARY_VALUE)
                    {
                        socValueRresult = 56250;
                    }
                    else
                    {
                        socValueRresult = 5 * salary / 100;
                    }
                    break;
            }
        }

        private static void CalculateSoc2(in int salary, in byte socValue, ref int socValueRresult)
        {
            throw new NotImplementedException();
        }



        private static void CalculateStamp(in int salary, out int stampPayValue)
        {
            stampPayValue = 0;
            if (salary <= 100000) { stampPayValue = 1500; }
            if (salary > 100000 && salary <= 200000) { stampPayValue = 3000; }
            if (salary > 200000 && salary <= 500000) { stampPayValue = 5500; }
            if (salary > 500000 && salary <= 1000000) { stampPayValue = 8500; }
            if (salary > 1000000) { stampPayValue = 15000; }
        }

        private static void CalculateSalary1(in int salary, in byte incomeTaxPercent, in int itSphereValue, in int socValueRersult, in int stampPayValue, ref int salaryResult)
        {
            salaryResult = salary - incomeTaxPercent * salary / 100 - socValueRersult - stampPayValue;
        }

        private static void CalculateSalary2(in int salary, in byte incomeTaxPercent, in int itSphereValue, in int socValueRersult, in int stampPayValue, ref int salaryResult)
        {
            throw new NotImplementedException();
        }


    }

}