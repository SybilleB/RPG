namespace RPG.Classes.HeroClasses;

public class Mage : HeroClass {
    
    public Mage() : base() {
        bonusStats.force = -1;
        bonusStats.intelligence = 1;
        bonusStats.agilite = -1;
        bonusStats.chance = 2;
    }
}