using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaseScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider faseSlider;
    public  float segInFas = 36;
    void Start()
    {
        
        faseSlider.maxValue -= segInFas;
    }

    // Update is called once per frame
    void Update()
    {
        segInFas -= Time.deltaTime;
        faseSlider.value += Time.deltaTime;
       

    }
}
