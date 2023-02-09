namespace Lesson1_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x += 3); // 5 + 3 = 8
            Console.WriteLine(x -= 3); // 8 - 3 = 5
            Console.WriteLine(x *= 3); // 5 * 3 = 15
            Console.WriteLine(x /= 3); // 15 / 3 = 5
            Console.WriteLine(x %= 3); // 5 % 3 = 2
            Console.WriteLine(new string('-', 20));

            string myOperator;
            double firstNumber, secondNumber, result = 0.00;
            bool compareResult = false;

            try
            {
                while (true)
                {

                    Console.Write("Enter First Number: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Second Number: ");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter operator: ");
                    myOperator = Console.ReadLine();

                    switch (myOperator)
                    {
                        case "+":
                            result = firstNumber + secondNumber;
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            break;
                        case "/":
                            result = firstNumber / secondNumber;
                            break;
                        case "%":
                            result = firstNumber % secondNumber;
                            break;
                        case "==":
                            compareResult = (firstNumber == secondNumber);
                            break;
                        case "!=":
                            compareResult = (firstNumber != secondNumber);
                            break;
                        default:
                            Console.WriteLine("WRONG OPERATOR");
                            return;
                    }
                    if (myOperator.Length == 2)
                    {
                        Console.WriteLine($"({firstNumber} {myOperator} {secondNumber}) = {compareResult}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {myOperator} {secondNumber} = {result}");
                    }
                    Console.WriteLine(new string('-', 20));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}