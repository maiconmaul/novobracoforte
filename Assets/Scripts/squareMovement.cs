using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class squareMovement : MonoBehaviour
{

   
   // public GameObject explosion;

    static SpaceShip ship;
    public TextMeshProUGUI dnaText;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        ship = new SpaceShip(4,4);
        slider.maxValue = ship.getResistence();
        slider.value = ship.getResistence();
    }
    public float vel = 0.1f;
    // Update is called once per frame
    void Update()
    {
       
       if (Input.GetKey(KeyCode.UpArrow))  
        {  
            Vector3 position = this.transform.position;
                         position.y += vel * Time.deltaTime;
                         this.transform.position = position;
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
           Vector3 position = this.transform.position;
                         position.y -= vel * Time.deltaTime;
                         this.transform.position = position;
              
        }  
         

    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Teste");
        //GameObject go = Instantiate(explosion) as GameObject;
        //go.transform.position = transform.position;
       
        if (other.gameObject.tag == "Meteor")
        {
            ship.removeLife(1);
            slider.value -= 1;
        }
        else if (other.gameObject.tag == "dna") {
            ship.addDna(1);
            String txt = ship.DnaCount.ToString();
            if (txt.Length == 1)
                txt = "0" + txt;
            dnaText.text = txt;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "radiation")
        {

            ship.removeLife(2);
            slider.value -= 2;
        }

        if (ship.getResistence() == 0)
        {
            this.gameObject.SetActive(false);
           
        }
       




    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
    }
}
