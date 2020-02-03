using System;

namespace kataCombeSophiene
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            MoneyChecker moneyChecker = new MoneyChecker();
            InputCustomerCommand inputCustomerCommand = new InputCustomerCommand(DrinkType.Tea, 2, 0.6, true);

            if (moneyChecker.CheckInputCoin(inputCustomerCommand) < 0)
                moneyChecker.ShowMissingMoney(inputCustomerCommand);
            else
                coffeeMachine.TranslateCommand(inputCustomerCommand);

            Console.ReadLine();
        }
    }
}
