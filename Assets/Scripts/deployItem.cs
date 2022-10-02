using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployItem : MonoBehaviour
{
    public GameObject meteor,dna,radiation;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(640, 480, false);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(itemWave());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnEnemy(){
        GameObject a;
        int r = Random.Range(0, 100);
        if (r < 10)
        {
            a = Instantiate(dna) as GameObject;
        }
        else if (r < 30) {
            a = Instantiate(radiation) as GameObject;
        }
        else {
            a = Instantiate(meteor) as GameObject;
        }
        
         a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(screenBounds.y, -screenBounds.y));
    }

     IEnumerator itemWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
     }
}
