using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class CoffeeMachine : EmailNotifier, BeverageQuantityChecker
    {
        private DrinkMaker drinkMaker;
        private List<DrinkCommand> listDrinkCommandHistory;
        public CoffeeMachine()
        {
            drinkMaker = new DrinkMaker();
        }

        internal void ShowMessage(string msg)
        {
            Console.WriteLine($"M:{msg}");
        }

        internal void TranslateCommand(InputCustomerCommand command)
        {
            var drinkCommand = AnalyzeCommand(command);
            SaveHistory(drinkCommand);
            sendCommandToDrinkMaker(drinkCommand);

        }

        private void SaveHistory(DrinkCommand drinkCommand)
        {
            if (listDrinkCommandHistory == null)
                listDrinkCommandHistory = new List<DrinkCommand>();
            listDrinkCommandHistory.Add(drinkCommand);
        }

        private static DrinkCommand AnalyzeCommand(InputCustomerCommand inputCustomer)
        {
            var sticks = inputCustomer.NbSugars != 0 ? "0" : "";
            return new DrinkCommand(inputCustomer);
        }

        internal void PrintHistory()
        {
            double totalAmount=0;
            foreach (var command in listDrinkCommandHistory)
            {
                Console.WriteLine($"{command.Type} Price : {command.Price} Sugar(s) {command.NbSugars} ExtraHot : {command.ExtraHot}");
                totalAmount += command.Price;
            }
            Console.WriteLine($"Total Money : {totalAmount}");
        }

        public void sendCommandToDrinkMaker(DrinkCommand drinkCommand)
        {
            drinkMaker.MakeDrinkCommand(drinkCommand);
        }

        public void notifyMissingDrink(DrinkCommand drink)
        {
            Console.WriteLine($"Drink : {drink.Type} is shortage !, We notify the maintenance service.");
        }

        public bool isEmpty(DrinkCommand drink)
        {
            var res = drink.Quantity == 0 ? true : false;
            return res;
        }
    }
}
