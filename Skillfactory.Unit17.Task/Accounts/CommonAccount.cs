namespace Skillfactory.Unit17.Task.Accounts
{
    public class CommonAccount: Account, ICalculate
    {
        public void CalculateInterest(CommonAccount account)
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
            {
                account.Interest -= account.Balance * 0.2;
            }

            if (account.Balance < 50000)
            {
                account.Interest -= account.Balance * 0.4;
            }
                
        }
    }
}