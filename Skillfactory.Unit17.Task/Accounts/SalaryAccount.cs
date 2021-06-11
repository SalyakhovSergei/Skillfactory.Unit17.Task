namespace Skillfactory.Unit17.Task.Accounts
{
    public class SalaryAccount: ICalculate
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}