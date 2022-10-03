using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlanetSceneScript : MonoBehaviour
{
    public SpriteRenderer spriteEarth;
    public SpriteRenderer spriteMars;
    [SerializeField] private TextMeshProUGUI daysOnThisPlanet;
    int days = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (Storages.CurrentPlanetID != 1)
        {
            this.spriteEarth.enabled = false;
            this.spriteMars.enabled = true;
        } 
        else
        {
            this.spriteEarth.enabled = true;
            this.spriteMars.enabled = false;
        }
        daysOnThisPlanet.text = "DAYS: " + days.ToString();
    }
    
    public void Rest()
    {
        days++;
        daysOnThisPlanet.text = "DAYS: " + days.ToString();
    }

    public void TravelNextPlanet()
    {
        SceneManager.LoadScene("TraveScene");
    }

    public void BuyUpgrade(int upgradeID)
    {
        Upgrades upgrade = GetUpgradeByID(upgradeID);
        Debug.Log(upgrade.ID.ToString());

        if (Storages.MainSpaceShip.DnaCount >= upgrade.Cost)
        {
            Debug.Log(Storages.MainSpaceShip.DnaCount.ToString());
            upgrade.Buy();
            Storages.MainSpaceShip.addResistence(upgrade.ResistanceBonus);
            Storages.MainSpaceShip.addPisciological(upgrade.SanityBonus);
            Storages.MainSpaceShip.AddRadiationResistance(upgrade.RadiationBonus);
            Storages.MainSpaceShip.RemoveDNA(upgrade.Cost);
            UpdateUpgradeByID(upgrade);
        } else {
            Debug.Log("DNA");
        }
    }

    private Upgrades GetUpgradeByID(int id)
    {
        Upgrades upgrade = new Upgrades();
        switch (id)
        {
            case 1:
                upgrade = Storages.LifePointsUpgrade;
            break;
            case 2:
                upgrade = Storages.SanityPointsUpgrade;
            break;
            case 3:
                upgrade = Storages.RatTalent;
            break;
            case 4:
                upgrade = Storages.TardigradeTalent;
            break;
            case 5:
                upgrade = Storages.GravityTalent;
            break;
            case 6:
                upgrade = Storages.EnvironmentTalent;
            break;
            default:
                Debug.Log("invalid upgrade");
            break;
        }
        return upgrade;
    }

    private void UpdateUpgradeByID(Upgrades upgrade)
    {
        switch (upgrade.ID)
        {
            case 1:
                Storages.LifePointsUpgrade = upgrade;
            break;
            case 2:
                Storages.SanityPointsUpgrade = upgrade;
            break;
            case 3:
                Storages.RatTalent = upgrade;
            break;
            case 4:
                Storages.TardigradeTalent = upgrade;
            break;
            case 5:
                Storages.GravityTalent = upgrade;
            break;
            case 6:
                Storages.EnvironmentTalent = upgrade;
            break;
            default:
                Debug.Log("invalid upgrade");
            break;
        }
    }
}
