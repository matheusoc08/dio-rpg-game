using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_rpg_game.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name) :
        base(Name)
        {
            this.HeroType = "Knight";
            this.HealthPoints += 200;
            this.PhysicalAttack = 40;
            this.MagicAttack = 20;
        }

        public Knight(string Name, string Item, int ItemPA, int ItemMA) :
        base(Name, Item, ItemPA, ItemMA)
        {
            this.HeroType = "Knight";
            this.HealthPoints += 200;
            this.PhysicalAttack = 40;
            this.MagicAttack = 20;
        }

        public Knight(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints) :
        base(Name, Level, HeroType, HealthPoints, ManaPoints)
        {
        }

    }
}