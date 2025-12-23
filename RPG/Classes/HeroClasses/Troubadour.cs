namespace RPG.Classes.HeroClasses;

public class Troubadour : HeroClass {
    
    public Troubadour() : base() {
        bonusStats.force = -1;
        bonusStats.charisme = -1;
        bonusStats.agilite = 1;
        bonusStats.chance = 3;
    }
}