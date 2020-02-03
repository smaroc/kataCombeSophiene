using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class InputCustomerCommand : DrinkCommand
    {

        public InputCustomerCommand(DrinkType type, int nbSugars) : base()
        {
            base.Type = type;
            base.NbSugars = nbSugars;
        }
    }
}
