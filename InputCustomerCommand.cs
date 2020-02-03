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
                    base.Quantity = 0;
                    break;

                case DrinkType.Coffee:
                    base.Price = 0.6;
                    base.Quantity = 2;
                    break;

                case DrinkType.Chocolate:
                    base.Price = 0.5;
                    base.Quantity = 2;

                    break;
                case DrinkType.OrangeJuice:
                    base.Price = 0.6;
                    base.Quantity = 2;

                    break;
                default:
                    break;
            }



        }
    }
}
