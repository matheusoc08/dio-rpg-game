using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_rpg_game.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name) :
        base(Name)
        {
            this.HeroType = "White Wizard";
            this.MagicAttack += 20;
            this.ManaPoints += 100;
        }

        public WhiteWizard(string Name, string Item, int ItemPA, int ItemMA) :
        base(Name, Item, ItemPA, ItemMA)
        {
            this.HeroType = "White Wizard";
            this.MagicAttack += 20;
            this.ManaPoints += 100;
        }

        public WhiteWizard(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints) :
        base(Name, Level, HeroType, HealthPoints, ManaPoints)
        {
        }

        public override string Magic()
        {
            this.ManaPoints -= 10;
            return $"{this.Name} atacou com magia das sombras. Causou {this.MagicAttack} de dano.";
        }

        public string Magic(int bonus)  
        {
            this.ManaPoints -= 30;

            string magic =  $"{this.Name} atacou com magia das sombras. Causou {this.MagicAttack} de dano.";
            if (bonus > 6)
            {
                magic += $" O ataque foi super efetivo com bonus de {bonus}.";
            } else {
                magic += $" O ataque foi fraco com bonus de {bonus}.";
            }

            return magic;
        }

    }
}