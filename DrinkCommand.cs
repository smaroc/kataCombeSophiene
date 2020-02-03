using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class DrinkCommand
    {
        public DrinkType Type { get; set; }

        public int NbSugars { get; set; }

        public string IsStick { get; }
        public double Price { get; set; }
        public bool ExtraHot { get; set; }

        public DrinkCommand()
        {

        }

        public DrinkCommand(InputCustomerCommand inputCustomerCommand)
        {
            this.Type = inputCustomerCommand.Type;
            this.NbSugars = inputCustomerCommand.NbSugars;
            this.IsStick = inputCustomerCommand.IsStick;
            this.ExtraHot = inputCustomerCommand.ExtraHot;
        }

        public override string ToString()
        {
            var returnMsg = (ExtraHot == true) ? $"{((char)Type).ToString()}h:{NbSugars}:{IsStick}" : $"{((char)Type).ToString()}:{NbSugars}:{IsStick}";
            return returnMsg;
        }
    }
}
