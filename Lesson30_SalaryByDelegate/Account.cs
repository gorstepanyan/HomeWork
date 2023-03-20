namespace Lesson30_Delegate
{
    delegate void AccountHandler(string message);
    internal class Account
    {
        int _sum;
        public Account(int sum)
        {
            _sum = sum;
        }

        AccountHandler? takenHandler;
        public void RegisterHandler(AccountHandler handler)
        {
            takenHandler += handler;
        }
        public void UnRegisterHandler(AccountHandler handler)
        {
            takenHandler -= handler;
        }


        public void Taken(int sum)
        {
            if (_sum > sum)
            {
                _sum -= sum;
                takenHandler?.Invoke($"Debited from account {sum} y.e.");
            }
            else
            {
                takenHandler?.Invoke($"Insufficient funds. Balance: {_sum} y.e.");
            }
        }


    }
}
