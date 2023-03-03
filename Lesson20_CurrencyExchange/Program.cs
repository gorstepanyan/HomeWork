namespace Lesson20_CurrencyExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool ok = true;
            Currency currency = new Currency();
            long dram = 0;

            Console.Write("Pleace, enter 1 for USD, 2 for EUR, 3 for RUB : ");
            do
            {
                try
                {
                    ok = true;
                    int exchangeType = Convert.ToByte(Console.ReadLine());
                    switch (exchangeType)
                    {
                        case 1:
                            currency = Currency.USD;
                            break;
                        case 2:
                            currency = Currency.EUR;
                            break;
                        case 3:
                            currency = Currency.RUB;
                            break;
                        default:
                            Console.Write("Pleace, enter correct exchange type. Try again : ");
                            ok = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write("Pleace, enter correct exchange type. Try again : ");
                    ok = false;
                }
                finally
                {

                }
            }
            while (ok == false);

            Console.Write("Pleace, enter DRAM : ");
            do
            {
                try
                {
                    ok = true;
                    dram = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write("Pleace, enter correct DRAM number. Try again : ");
                    ok = false;
                }
                finally
                {

                }
            }
            while (ok == false);

            Exchange(dram, currency);
            Console.ReadLine();

        }

        static void Exchange(double dram, Currency currency)
        {
            double sum = 0.00;
            int mainSum = 0,
                decimalSum = 0;

            switch (currency)
            {
                case Currency.USD:
                    sum = Math.Round(dram / (double)currency, 2);
                    mainSum = (int)sum;
                    decimalSum = (int)(sum % 1 * 100);
                    Console.WriteLine($"{mainSum} {Currency.USD}, {decimalSum} cent");
                    break;
                case Currency.EUR:
                    sum = Math.Round(dram / (double)currency, 2);
                    mainSum = (int)sum;
                    decimalSum = (int)(sum % 1 * 100);
                    Console.WriteLine($"{mainSum} {Currency.EUR}, {decimalSum} eurocent");
                    break;
                case Currency.RUB:
                    sum = Math.Round(dram * 1000 / (double)currency, 2);
                    mainSum = (int)sum;
                    decimalSum = (int)(sum % 1 * 100);
                    Console.WriteLine($"{mainSum} {Currency.RUB}, {decimalSum} kopek");
                    break;
                default:
                    Console.WriteLine("Please, input correct currency. Try again.");
                    break;
            }
        }
    }
}