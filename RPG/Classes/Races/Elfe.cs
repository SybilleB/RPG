namespace RPG.Classes.Races;


public class Elfe : Race {
    
    public Elfe():base(Stats _stats){}
    
    public override Stats bonusAttributs()
    {
        Stats BaseStats = base.bonusAttributs();
        BaseStats.intelligence += 1;
        BaseStats.agilite += 1;
        return BaseStats;
    }
}