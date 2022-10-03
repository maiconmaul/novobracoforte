using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class squareMovement : MonoBehaviour
{

   
   // public GameObject explosion;

    public TextMeshProUGUI dnaText;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        //ship = new SpaceShip(4,4);
        slider.maxValue = Storages.MainSpaceShip.ResistenceMax;
        slider.value = Storages.MainSpaceShip.getResistence();
        String txt = Storages.MainSpaceShip.DnaCount.ToString();
        if (txt.Length == 1)
            txt = "0" + txt;
        dnaText.text = txt;
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
            Destroy(other.gameObject);
            Storages.MainSpaceShip.removeLife(1);
            slider.value -= 1;
        }
        else if (other.gameObject.tag == "dna") {
            Storages.MainSpaceShip.addDna(1);
            String txt = Storages.MainSpaceShip.DnaCount.ToString();
            if (txt.Length == 1)
                txt = "0" + txt;
            dnaText.text = txt;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "radiation")
        {
            Storages.MainSpaceShip.removeLife(2);
            slider.value -= 2;
        }

        if (other.gameObject.tag == "life")
        {
            if(Storages.MainSpaceShip.getResistence() < Storages.MainSpaceShip.ResistenceMax)
            {
                Storages.MainSpaceShip.addResistence(1);
                slider.value += 1;
              
            }
            Destroy(other.gameObject);
        }

        if (Storages.MainSpaceShip.getResistence() <= 0)
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene("PlanetScene");
           
        }
       




    }
    private void moveUp() { 

    }

    private void moveDown() { 

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        
    }
}
