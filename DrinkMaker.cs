using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class DrinkMaker
    {
        public DrinkMaker()
        {

        }

        public void MakeDrinkCommand(DrinkCommand drinkCommand)
        {
            drinkCommand.Quantity--;
            Console.WriteLine(drinkCommand.ToString());

        }


    }
}
