using Skillfactory.Unit17.Task.Accounts;

namespace Skillfactory.Unit17.Task
{
    public static class Calculator 
    { 
        // Метод для расчета процентной ставки
        public static void CalculateInterest(ICalculate calculate) 
        { 
            calculate.CalculateInterest(new CommonAccount());
        }
    } 
}