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
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
