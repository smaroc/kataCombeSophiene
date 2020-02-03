using System;
using System.Collections.Generic;

namespace kataCombeSophiene
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            MoneyChecker moneyChecker = new MoneyChecker();
            List<InputCustomerCommand> inputCustomerCommands = new List<InputCustomerCommand>{
                new InputCustomerCommand(DrinkType.Tea, 2, 0.6, true),
            new InputCustomerCommand(DrinkType.OrangeJuice, 2, 0.6, false),
            new InputCustomerCommand(DrinkType.Chocolate, 2, 0.6, true)};

            foreach (var inputCustomerCommand in inputCustomerCommands)
            {
                if (moneyChecker.CheckInputCoin(inputCustomerCommand) < 0)
                    moneyChecker.ShowMissingMoney(inputCustomerCommand);
                else
                    coffeeMachine.TranslateCommand(inputCustomerCommand);

            }


            coffeeMachine.PrintHistory();

            Console.ReadLine();
        }
    }
}
