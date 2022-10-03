using System.Collections;
using System.Collections.Generic;

public class Storages
{
    public static SpaceShip MainSpaceShip = new SpaceShip(4, 4);
    public static int CurrentPlanetID = 1;
    public static int DaysInCurrentPlanet = 1;
    //Upgrades(int id, int cost, int radiationBonus, int resistanceBonus, int sanityBonus, int healPoints)
    public static Upgrades LifePointsUpgrade = new Upgrades(1, "", 5, 0, 1, 0, 0);
    public static Upgrades SanityPointsUpgrade = new Upgrades(2, "", 5, 0, 1, 0, 0);
    public static Upgrades RatTalent = new Upgrades(3, "", 10, 1, 0, 0, 0); 
    public static Upgrades TardigradeTalent = new Upgrades(4, "", 10, 1, 0, 0, 0); 
    public static Upgrades GravityTalent = new Upgrades(5, "", 9999, 0, 0, 0, 0); 
    public static Upgrades EnvironmentTalent = new Upgrades(6, "", 9999, 0, 0, 0, 0);
    public static bool stop = false;

}
