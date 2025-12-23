namespace RPG.Classes.HeroClasses;

public class Voleur : HeroClass {
    
    public Voleur() : base() {
        bonusStats.force = -1;
        bonusStats.charisme = -1;
        bonusStats.intelligence = 1;
        bonusStats.agilite = 2;
    }
}