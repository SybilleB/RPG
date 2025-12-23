namespace RPG.Classes.HeroClasses;

public class Guerrier : HeroClass { 
    
    public Guerrier() : base() {
        bonusStats.force = 2;
        bonusStats.charisme = 1;
        bonusStats.agilite = -2;
    }
}