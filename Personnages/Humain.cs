﻿using Rpg_Game.npj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rpg_Game.Personnages
{
    public class Humain : Hero
    { 
        public Humain(string name) : base(name)
        {
            Stats[StatType.Endurance] += 1;
            Stats[StatType.Force] += 1;
        }
   
    }
    

    
}
