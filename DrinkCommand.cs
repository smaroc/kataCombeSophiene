using System;
using System.Collections.Generic;
using System.Text;

namespace kataCombeSophiene
{
    public class DrinkCommand
    {
        public string Type { get; }

        public string NbSugars { get; }

        public string IsStick { get; }

        public DrinkCommand(string type, string sugar, string stick)
        {
            this.Type = type;
            this.NbSugars = sugar;
            this.IsStick = stick;
        }

        public override string ToString()
        {
            return $"{Type}:{NbSugars}:{IsStick}";
        }
    }
}
