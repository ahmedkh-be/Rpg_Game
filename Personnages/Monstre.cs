using Rpg_Game.npj;
using Rpg_Game.Utils;
using System.Xml.Linq;


namespace Rpg_Game.Personnages

{
    
    public class Monstre : Personnage
    {
        
        public Monstre(string race, int nbor, int nbcuir ) : base(DiceType.D6, nbor, nbcuir)
        {
            Race = race;
            NbOr = nbor;
            NbCuir = nbcuir;     
        }

        public string Race { get; set; }
        public void Frapper(Hero h) {
            if (h.IsAlive)
            {
                Console.WriteLine($"♦ ♦ ♦ {h.Name} VS {Race} ♦ ♦ ♦");
                Console.WriteLine($"- {Race} attaque -> {h.Name} !");
                h.Stats[StatType.Pv] -= GenerateDegat();
                Console.WriteLine($"{h.Name} ({h.Pv}♥)  |  {Race} ({Pv}♥)\n");
                if (!h.IsAlive)
                    h.RaiseDieEvent();
            }
            else if (h.IsAlive == false)
                Console.WriteLine($"- Oh non ! {h.Name} est MORT  !");
                    }
        public override string ToString()
        {
            return $"{Race}:\n" + base.ToString();
        }
    }
}

