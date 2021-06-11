using System;
using Skillfactory.Unit17.Task.Accounts;

namespace Skillfactory.Unit17.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.CalculateInterest(new CommonAccount());
            calculator.CalculateInterest(new SalaryAccount());
        }
    }
}