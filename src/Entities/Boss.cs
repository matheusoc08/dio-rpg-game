using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_rpg_game.src.Entities
{
    public interface Boss
    {
        public string Name { get; set; }

        public string Roar();
    }
}