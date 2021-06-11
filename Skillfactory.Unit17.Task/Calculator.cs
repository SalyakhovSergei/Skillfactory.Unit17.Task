using Skillfactory.Unit17.Task.Accounts;
using Skillfactory.Unit17.Task.Instructions;

namespace Skillfactory.Unit17.Task
{
    public class Calculator 
    { 
        // Метод для расчета процентной ставки
        public void CalculateInterest(ICalculate calculate) 
        { 
            calculate.CalculateInterest(new Account());
        }
    } 
}