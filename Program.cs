using System;

namespace kataCombeSophiene
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine  coffeeMachine = new CoffeeMachine();
            coffeeMachine.TranslateCommand("Drink maker makes 1 tea with 1 sugar and a stick");
            Console.ReadLine();
        }
    }
}
