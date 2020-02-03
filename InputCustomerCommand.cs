using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class InputCustomerCommand : DrinkCommand
    {

        public double InputCoin { get; }
        public InputCustomerCommand(DrinkType type, int nbSugars, double input) : base()
        {
            base.Type = type;
            base.NbSugars = nbSugars;
            this.InputCoin = input;

            switch (type)
            {
                case DrinkType.Tea:
                    base.Price = 0.4;
                    break;

                case DrinkType.Coffee:
                    base.Price = 0.6;
                    break;

                case DrinkType.Chocolate:
                    base.Price = 0.5;
                    break;

                default:
                    break;
            }

        }
    }
}
