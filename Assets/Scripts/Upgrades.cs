using System.Collections;
using System.Collections.Generic;

public class Upgrades
{
    private int id, name, quantityPurchased, cost, radiationBonus, resistanceBonus, sanityBonus, healPoints;
    
    public Upgrades(int id, string name, int cost, int radiationBonus, int resistanceBonus, int sanityBonus, int healPoints)
    {
        this.id = id;
        this.name = name;
        this.cost = cost;
        this.radiationBonus = radiationBonus;
        this.resistanceBonus = resistanceBonus;
        this.healPoints = healPoints;
        this.sanityBonus = sanityBonus;
        this.quantityPurchased = 0;
    }

    public Upgrades(){ }

    public void Buy()
    {
        this.quantityPurchased++;
    }

    public int ID {get => id; }
    public int Cost {get => cost;}
    public int RadiationBonus {get => radiationBonus;}
    public int ResistanceBonus {get => resistanceBonus;}
    public int SanityBonus {get => sanityBonus;}
}
