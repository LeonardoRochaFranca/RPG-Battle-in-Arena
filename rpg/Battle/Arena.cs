﻿using rpg.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace rpg.Battle
{
    public class Arena
    {
        public int ArenaLevel { get; set; }
        public Arena(int arenaLevel)
        {
            this.ArenaLevel = arenaLevel;
        }
        public void Battle(Hero hero, Hero hero2, Hero boss)
        {
            Console.Clear();
            int round = 1;
            int restoreHero = hero.LifePoints;
            int restorePower = hero.Power;
            int restoreHero2 = hero2.LifePoints;
            int restorePower2 = hero2.Power;
            int restoreBoss = boss.LifePoints;
            int restorePowerB = boss.Power;
            Console.WriteLine($"{hero.Name} & {hero2.Name} x {boss.Name}");
            do
            {
               
                Console.WriteLine(" ");
                Console.WriteLine($"Round {round}");
                Console.WriteLine($"{hero.Name} Life= {hero.LifePoints} / {restoreHero}");
                Console.WriteLine($"{hero2.Name} Life= {hero2.LifePoints} / {restoreHero2}");
                Console.WriteLine($"{boss.Name} Life= {boss.LifePoints} / {restoreBoss}");

                if (round % 2 != 0)
                {
                   
                    if (hero.LifePoints > 0)
                    {
                        boss.Damage(hero.Power);
                        Thread.Sleep(2000);

                        boss.Damage(hero2.Power);
                        Thread.Sleep(2000);

                        hero.Damage(boss.Power);
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        boss.Damage(hero2.Power);
                        Thread.Sleep(2000);

                        hero2.Damage(boss.Power);
                        Thread.Sleep(2000);
                    }

                }
                else if (round % 2 == 0)
                {
                    if (hero2.LifePoints > 0)
                    {
                    boss.Damage(hero.Power);
                    Thread.Sleep(2000);

                    boss.Damage(hero2.Power);
                    Thread.Sleep(2000);

                    hero2.Damage(boss.Power);
                    Thread.Sleep(2000);
                    }
                    else
                    {
                        boss.Damage(hero.Power);
                        Thread.Sleep(2000);

                        hero.Damage(boss.Power);
                        Thread.Sleep(2000);
                    }
                }
                round++;
                if ((hero.LifePoints <= 0))
                {
                    Console.WriteLine($"{hero.Name} is out of combat!");
                    hero.Defeat();
                    Thread.Sleep(1000);
                }
                if ((hero2.LifePoints <= 0))
                {
                    Console.WriteLine($"{hero2.Name} is out of combat!");
                    hero2.Defeat();
                    Thread.Sleep(1000);
                }

            } while ((hero.LifePoints >= 0 || hero2.LifePoints >= 0) && boss.LifePoints >= 0);

            Thread.Sleep(2000);
            Console.Clear();

            hero.Restore(restoreHero, restorePower);
            hero2.Restore(restoreHero2, restorePower2);

            if (boss.LifePoints > 0)
            {
                Console.Write("Your Team are defeat.");
                Thread.Sleep(2000);
                Console.WriteLine($"{boss.Name} Wins!!!");
                Thread.Sleep(2000);
                Console.WriteLine("Game Over!");
                
            }
            else
            {

                Console.WriteLine("VICTORY!!!");
                Thread.Sleep(2000);

                Console.WriteLine("Your team is really strong");
                Thread.Sleep(2000);

                hero.Evolution();
                Thread.Sleep(2000);

                Console.WriteLine($"Congrulations! Now {hero.Name} is level {hero.Level}!");
                Thread.Sleep(2000);

                Console.WriteLine(hero);
                Thread.Sleep(2000);

                hero2.Evolution();
                Thread.Sleep(2000);

                Console.WriteLine($"Congrulations! Now {hero2.Name} is level {hero2.Level}!");
                Thread.Sleep(2000);

                Console.WriteLine(hero2);
            }
        }
    }
}
