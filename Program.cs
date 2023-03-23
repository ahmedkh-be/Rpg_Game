using Rpg_Game.npj;
using Rpg_Game.Personnages;

/*
    ---  Création des Personnages  ---
*/

// P1 -> Humain
Humain P1 = new Humain("Gitano");
P1.Affiche();

// P2 -> Nain
Nain P2 = new Nain("Demi");
P2.Affiche();

// monstre_l1 -> Loup
Loup monstre_l1 = new Loup("Loup");
monstre_l1.Affiche();

// monstre_d1 -> Dragonnet
Dragonet monstre_d1 = new Dragonet("Dragonet");
monstre_d1.Affiche();

// monstre_o1 -> Orc
Orc monstre_o1 = new Orc("Orc");
monstre_o1.Affiche();

Console.WriteLine("\n");

/*
    ---  Actions du jeu  ---
*/

// P1 & P2 vs monstre_d1
P1.Frapper(monstre_d1);
P2.Frapper(monstre_d1);
P1.Frapper(monstre_d1);
P2.Frapper(monstre_d1);


// P1 vs monstre_d1
monstre_o1.Frapper(P2);

// P2 se soigne
P2.SeSoigner();


Console.WriteLine("\n");
Console.WriteLine("\n");
