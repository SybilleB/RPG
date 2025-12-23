using RPG.Classes.HeroClasses;
using RPG.Classes.Races;

namespace RPG.Classes;

public class Personnage {
    public string nomJoueur;
    public Race race;
    public HeroClass hero;
    
    public Personnage(string _nomJoueur, Race _race, HeroClass _hero) {
        
        if (!_race.classeAutorisee(_hero)) {
            Console.WriteLine("Erreur, un " + _race.GetType().Name + "ne peut pas être un " + _hero.GetType().Name);
            return; 
        }
        else {
            nomJoueur = _nomJoueur;
            race = _race;
            hero = _hero;

            race.stats.ajouterStats(hero.bonusStats);
            affinités(); 
        }
    }

    public void affinités() {
        if (race is Humain && hero is Guerrier) {
            race.stats.force += 2;
        }
        if (race is Elfe && hero is Voleur) {
            race.stats.agilite += 2;
        }
        if (race is Nain && hero is Alchimiste) {
            race.stats.vitalite += 2;
        }
        if (race is Gobelin && hero is Troubadour) {
            race.stats.chance += 2;
        }
        if (race is Fee && hero is Mage) {
            race.stats.intelligence += 2;
        }
    }

    public void afficherInfosTotales() {
        Console.WriteLine("===============================");
        Console.WriteLine("Nom du joueur : " +  nomJoueur + "\n");
        race.afficherInfos();
        Console.WriteLine("===============================");
    }
    
}