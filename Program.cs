using System;

namespace kataCombeSophiene
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine  coffeeMachine = new CoffeeMachine();
            InputCustomerCommand inputCustomerCommand = new InputCustomerCommand(DrinkType.Tea, 1);
            coffeeMachine.TranslateCommand(inputCustomerCommand);
            Console.ReadLine();
        }
    }
}
