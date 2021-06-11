namespace Skillfactory.Unit17.Task.Accounts
{
    public class SalaryAccount: Account, ICalculate
    {
        public void CalculateInterest(CommonAccount account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}