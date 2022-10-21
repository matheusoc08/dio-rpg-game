using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_rpg_game.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) :
        base(Name, Level, HeroType)
        {
        }
        

        public override string Attack()
        {
            return $"{this.Name} atacou com magia.";
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