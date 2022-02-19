using System;
using System.Collections.Generic;
using System.Text;

namespace rpg.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; protected set; }
        public String Type { get; protected set; }
        public int LifePoints { get; protected set; }
        public int Power { get; protected set; }

        public Hero()
        {

        }
        public Hero(string Name)
        {
            this.Name = Name;
            Level = 1;
            Type = "Type" ;
            LifePoints = 0;
            Power = 0;
        }
        public virtual void Evolution()
        {
            Level++;
            LifePoints += Level;
            Power += Level;
        }
        public virtual void Evolution(int level)
        {
            Level++;
            LifePoints += Level;
            Power += Level;
        }
        public void Damage(int power)
        {
            this.LifePoints -= power;
        }
        public void Restore(int restoreLife, int restorePower)
        {
            this.LifePoints = restoreLife;
            this.Power = restorePower;
        }
        //public virtual string Attack()
        //{
        //   return this.Name + " " + Power ;
        //}
        //public void Ultimate(int power)
        //{
        //    this.LifePoints -= power + 1 ;
        //}

        public void Defeat()
        {
            Power = 0;
        }

        public override string ToString()
        {
            return "\n" + "Character: \n" + 
                  "Name: " + Name + "\n" +
                  "Level: " + Level + "\n" +
                  "Type: " + Type + "\n" +
                  "LifePoints: " + LifePoints + "\n" +
                  "Power: " + Power + "\n";
        }
    }
}
