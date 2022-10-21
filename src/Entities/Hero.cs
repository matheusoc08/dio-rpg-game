using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_rpg_game.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
        }

        public override string ToString()
        {
            return $"Nome: {this.Name}\nClasse: {this.HeroType}\nLevel: {this.Level}\n";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com a espada.";
        }

    }
}