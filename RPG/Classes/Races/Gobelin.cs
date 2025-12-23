using RPG.Classes.HeroClasses;

namespace RPG.Classes.Races;

public class Gobelin : Race {
    
    public Gobelin(string _nom, string _genre, int _poids) : base(_nom, _genre, _poids, new Stats()) {
        stats.force += 3;
        stats.charisme -= 1;
        stats.intelligence -= 1;
        stats.chance -= 1;
    }
    
    public override bool classeAutorisee(HeroClass classe) {
        if (classe is Guerrier || classe is Voleur || classe is Troubadour) {
            return true;
        }
        else {
            return false;
        }
    }
}