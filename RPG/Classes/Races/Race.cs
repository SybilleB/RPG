using System;

public class Stats { //Attributs, utiles pour les méthodes virtuelles à override
    public int force; 
    public int charisme;
    public int intelligence;
    public int agilite;
    public int vitalite;
    public int chance;

    public Stats()
    {
        force = 0;
        charisme = 0;
        intelligence = 0;
        agilite = 0;
        vitalite = 0;
        chance = 0;
    }
}

public class Race
{
    public string nom;
    public string genre;
    public int poids;
    public int pv;
    public Stats stats;

    public Race(Stats _stats) {
        pv = 100;
        stats = _stats;
    }

    public Race(string nom, int poids) {
        this.nom = nom;
        this.poids = poids;
        pv = 100;
    }

    public virtual Stats bonusAttributs() {
        return new Stats();
    }
}