using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaseScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider faseSlider;
    void Start()
    {
        faseSlider.maxValue = 30;
    }

    // Update is called once per frame
    void Update()
    {
        faseSlider.value += Time.deltaTime;
    }
}
