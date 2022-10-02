using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlanetSceneScript : MonoBehaviour
{
    public static int planetID = 1;
    [SerializeField] private TextMeshProUGUI daysOnThisPlanet;
    int days;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
