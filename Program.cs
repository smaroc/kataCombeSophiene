using System;

namespace kataCombeSophiene
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            MoneyChecker moneyChecker = new MoneyChecker();
            InputCustomerCommand inputCustomerCommand = new InputCustomerCommand(DrinkType.Tea, 1, 0.3);

            if (moneyChecker.CheckInputCoin(inputCustomerCommand) < 0)
                moneyChecker.ShowMissingMoney(inputCustomerCommand);
            else
                coffeeMachine.TranslateCommand(inputCustomerCommand);

            Console.ReadLine();
        }
    }
}
