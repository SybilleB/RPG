using System;
using RPG.Classes;
using RPG.Classes.HerosClasses;
using RPG.Classes.Races;


Console.WriteLine("Bienvenue dans : Simulateur de Ramasseur Compulsif ! ");
Nain n1 = new Nain("George", "masculin", 80);
Humain h1 = new Humain("Julia", "feminin", 60);


/*Gobelin g1 = new Gobelin("Rork", "masculin", 120);
g1.afficherInfos();

Fee f1 = new Fee("Auriane",  "feminin", 5);
f1.afficherInfos();

Elfe e1 = new Elfe("Legolas", "masculin", 50);
e1.afficherInfos();*/


Guerrier g1 = new Guerrier();
Alchimiste a1 = new Alchimiste();

Personnage p1 = new Personnage("azerty", h1, g1);
Personnage p2 = new Personnage("azerty", n1, a1);


p1.afficherInfosTotales();
p2.afficherInfosTotales();