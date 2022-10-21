using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_rpg_game.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name) :
        base(Name)
        {
            this.HeroType = "Black Wizard";
            this.MagicAttack += 40;
            this.ManaPoints += 150;
        }

        public BlackWizard(string Name, string Item, int ItemPA, int ItemMA) :
        base(Name, Item, ItemPA, ItemMA)
        {
            this.HeroType = "Black Wizard";
            this.MagicAttack += 40;
            this.ManaPoints += 150;
        }

        public BlackWizard(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints) :
        base(Name, Level, HeroType, HealthPoints, ManaPoints)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} atacou com magia das sombras.";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.Name} lançou uma magia super efetiva com bonus de {bonus}.";
            }
            return $"{this.Name} lançou uma magia fraca com bonus {bonus}.";
        }

    }
}