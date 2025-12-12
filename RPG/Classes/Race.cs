namespace RPG.Classes;

public class Race
{
    public string nom;
    public int poids;
    public int pv;

    public Race() {
        pv = 100;
    }

    public Race(string nom, int poids) {
        this.nom = nom;
        this.poids = poids;
        pv = 100;
    }
    
}