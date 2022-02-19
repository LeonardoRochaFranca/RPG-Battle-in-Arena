using System;
using System.Collections.Generic;
using System.Text;

namespace rpg.Entities
{
    public class Knight:Hero
    {
        public Knight(string Name)
        {
            this.Name = Name;
            Level = 1;
            Type = "Knight";
            LifePoints = 11;
            Power = 2;
        }

    }
}
