﻿namespace Skillfactory.Unit17.Task.Accounts
{
    public abstract class Account
    {
       // тип учетной записи
        public string Type { get; set; }
  
        // баланс учетной записи
        public double Balance { get; set; }
  
        // процентная ставка
        public double Interest { get; set; }
    }
}