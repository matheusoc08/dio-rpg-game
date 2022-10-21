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
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public int PhysicalAttack { get; set; }
        public int MagicAttack { get; set; }
        public string Item { get; set; }

        public Hero(string Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.HealthPoints = 300;
            this.ManaPoints = 50;
            this.PhysicalAttack = 10;
            this.MagicAttack = 5;
            this.Item = "punho";
        }

        public Hero(string Name, string Item, int ItemPA, int itemMA)
        {
            this.Name = Name;
            this.Level = 1;
            this.HealthPoints = 300;
            this.ManaPoints = 50;
            this.PhysicalAttack = 10 + ItemPA;
            this.MagicAttack = 5 + itemMA;
            this.Item = Item;
        }

        public Hero(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints)
        {
            this.HealthPoints = HealthPoints;
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.ManaPoints = ManaPoints;
        }

        public override string ToString()
        {
            return
                $"Nome: {this.Name}\n"+
                $"Classe: {this.HeroType}\n"+
                $"Level: {this.Level}\n"+
                $"HP: {this.HealthPoints}\n"+
                $"MP: {this.ManaPoints}\n"+
                $"Atk: {this.PhysicalAttack}\n"+
                $"Mgc: {this.MagicAttack}\n"+
                $"Item: {this.Item}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com {this.Item}. Causou {this.PhysicalAttack} de dano.";
        }

        public virtual string Magic()
        {
            this.ManaPoints -= 10;
            return $"{this.Name} atacou com magia. Causou {this.MagicAttack} de dano.";
        }

    }
}