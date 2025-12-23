namespace RPG.Classes.HeroClasses;

public class HeroClass {
    
    public Stats bonusStats;

    public HeroClass() {
        bonusStats = new Stats();
    }
    
    public virtual int attaqueSpeciale() {
        return 0;
    } //Revoir cette méthode à override
}