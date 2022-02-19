using System;
using System.Collections.Generic;
using System.Text;

namespace rpg.Entities
{
    public class Boss : Hero
    {
        public Boss(string Name)
        {
            this.Name = Name;
            Level = 1;
            Type = "Devil";
            LifePoints = 20;
            Power = 5;
        }

        public void ArenaBoss(int arenaLevel)
        {
            Level = arenaLevel;
            LifePoints += (Level*2);
            Power += Level;
        }

    }
}
