using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class InputCustomerCommand : DrinkCommand
    {

        public double InputCoin { get; }
        public InputCustomerCommand(DrinkType type, int nbSugars, double input, bool extraHot) : base()
        {
            base.Type = type;
            base.NbSugars = nbSugars;
            base.ExtraHot = extraHot;

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
                case DrinkType.OrangeJuice:
                    base.Price = 0.6;
                    break;
                default:
                    break;
            }

        }
    }
}
