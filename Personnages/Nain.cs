using Rpg_Game.npj;
using System.Net.NetworkInformation;

namespace Rpg_Game.Personnages
{
    public class Nain : Hero
    {
        public Nain(string name) : base(name)
        {
            Stats[StatType.Endurance] += 2;

        }
    }
    
}
