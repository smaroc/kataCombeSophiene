using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class CoffeeMachine
    {
        public CoffeeMachine()
        {
        }

        internal void TranslateCommand(string command)
        {

            var drinkCommand = AnalyzeCommand(command);
            sendCommandToDrinkMaker(drinkCommand);

        }

        private static DrinkCommand AnalyzeCommand(string command)
        {
            string[] cmdSplit = command.Split(" ");
            var type = cmdSplit[4];
            var sugar = int.TryParse(cmdSplit[6], out int nbSugar);
            string typeTranslate = null;

            switch (type)
            {
                case "tea":
                    typeTranslate = "T";
                    break;
                case "chocolate":
                    typeTranslate = "H";
                    break;
                case "coffee":
                    typeTranslate = "C";
                    break;
                default:
                    break;
            }

            var nbSugars = (sugar == true) ? nbSugar.ToString() : "";
            var sticks = (sugar == true) ? "0" : "";
            return new DrinkCommand(typeTranslate, nbSugars, sticks);

        }

        public void sendCommandToDrinkMaker(DrinkCommand drinkCommand)
        {
            Console.WriteLine(drinkCommand.ToString());
        }


    }
}
