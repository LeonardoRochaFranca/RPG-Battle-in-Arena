using System;
using System.Collections.Generic;
using System.Text;

namespace rpg.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name)
        {
            this.Name = Name;
            Level = 1;
            Type = "Wizard";
            LifePoints = 9;
            Power = 4;
        }

        //public override string Attack()
        //{
        //    return this.Name + " lança feitiço e causa: " + Power + " de dano;";
        //}

    }
}
