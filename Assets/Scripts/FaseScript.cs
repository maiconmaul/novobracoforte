using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FaseScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider faseSlider;
    public  float segInFas = 36;
    void Start()
    {
        
        faseSlider.maxValue = segInFas;
    }

    // Update is called once per frame
    void Update()
    {
       
        faseSlider.value += Time.deltaTime;
        if (faseSlider.value >= (segInFas  - 1))
        {
            Storages.stop = true;
            Storages.CurrentPlanetID += 1;
            Storages.DaysInCurrentPlanet = 1;
            SceneManager.LoadScene("PlanetScene");
        }

       

    }
}
