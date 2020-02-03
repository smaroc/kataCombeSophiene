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

        public DrinkCommand()
        {

        }

        public DrinkCommand(DrinkType type, int sugar, string stick)
        {
            this.Type = type;
            this.NbSugars = sugar;
            this.IsStick = stick;
        }

        public override string ToString()
        {
            return $"{((char)Type).ToString()}:{NbSugars}:{IsStick}";
        }
    }
}
