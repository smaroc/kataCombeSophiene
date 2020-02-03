using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public interface EmailNotifier
    {
        void notifyMissingDrink(DrinkCommand drink);
}
}
