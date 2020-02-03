using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class CoffeeMachine
    {
        private DrinkMaker drinkMaker;
        public CoffeeMachine()
        {
            drinkMaker = new DrinkMaker();
        }

        internal void TranslateCommand(InputCustomerCommand command)
        {

            var drinkCommand = AnalyzeCommand(command);
            sendCommandToDrinkMaker(drinkCommand);

        }


        private static DrinkCommand AnalyzeCommand(InputCustomerCommand inputCustomer)
        {

            var sticks = inputCustomer.NbSugars != 0 ? "0" : "";

            return new DrinkCommand(inputCustomer.Type, inputCustomer.NbSugars, sticks);

        }


        public void sendCommandToDrinkMaker(DrinkCommand drinkCommand)
        {
            drinkMaker.MakeDrinkCommand(drinkCommand);
        }


    }
}
