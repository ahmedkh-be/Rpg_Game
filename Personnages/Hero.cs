using Rpg_Game;
using Rpg_Game.Extensions;
using Rpg_Game.Personnages;
using Rpg_Game.Utils;
using System.Diagnostics;

namespace Rpg_Game.npj

{
    //public delegate void Competence ();
    public class Hero : Personnage
    {
        
        public Action Competence1;
        public Func<int, int, float> test;
        //public Competence Competence1;
        public Action Competence2;
        public Action Combo;

        public Hero(string name) : base(DiceType.D10,0,0)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void SeSoigner()
        {
            Console.WriteLine($"- {Name}({Pv}) se soigne...");
            Stats[StatType.Pv] += 10;
            Console.WriteLine($"SUCCÈS ! -> {Name} a {Pv} PV");
        }
        public void Frapper(Monstre m)
        {

            if (m.IsAlive)
            {
                int degat = GenerateDegat();
                Console.WriteLine($"♦ ♦ ♦ {Name} VS {m.Race} ♦ ♦ ♦");
                Console.WriteLine($"- {Name} attaque -> {m.Race} !");
                Console.WriteLine($"- {m.Race} subit -{degat} PV !");
                m.Stats[StatType.Pv] -= degat;
                Console.WriteLine($"{Name} ({Pv}♥)  |  {m.Race} ({m.Pv}♥)\n");
                if (!m.IsAlive)
                {
                    Console.WriteLine($"SUCCÈS ! {m.Race} est MORT ! ☻ ☻ ☻");
                    Loot(m);
                }
            }
            else if (m.IsAlive == false)
            {
                m.RaiseDieEvent();
                
            }
        }
        
        public override string ToString()
        {
            return $"{Name}:\n" + base.ToString();
        }
        public void Loot(Monstre p)
        {
            Console.WriteLine($"- {Name} a looté -> {p.Race}\n");
        }
    }
}
