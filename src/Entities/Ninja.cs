using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_rpg_game.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name) :
        base(Name)
        {
            this.HeroType = "Ninja";
            this.PhysicalAttack += 50;
            this.MagicAttack += 15;
        }

        public Ninja(string Name, string Item, int ItemPA, int ItemMA) :
        base(Name, Item, ItemPA, ItemMA)
        {
            this.HeroType = "Ninja";
            this.PhysicalAttack += 50;
            this.MagicAttack += 15;
        }
        public Ninja(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints) :
        base(Name, Level, HeroType, HealthPoints, ManaPoints)
        {
        }
    }
}