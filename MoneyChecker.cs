using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class MoneyChecker
    {

        public MoneyChecker()
        {

        }

        internal double CheckInputCoin(InputCustomerCommand inputCustomerCommand)
        {
            double checkMoney = inputCustomerCommand.InputCoin - inputCustomerCommand.Price;
            return checkMoney;

        }

        internal void ShowMissingMoney(InputCustomerCommand inputCustomerCommand)
        {
            double checkMoney = Math.Abs(inputCustomerCommand.InputCoin - inputCustomerCommand.Price);
            Console.WriteLine($"You need to add {Math.Round(checkMoney,1)}");
        }
    }
}
