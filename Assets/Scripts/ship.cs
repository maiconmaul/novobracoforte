using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public GameObject animation;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("item: " + transform.position.x * -1);
        // Debug.Log("screen: " + screenBounds.x);
        if((transform.position.x * -1)  > (screenBounds.x * 2) ){
           
            Destroy(this.gameObject);

        }

       
    }
    GameObject e;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(gameObject.tag == "Meteor")
        {
            Destroy(this.gameObject);
            Debug.Log("teststs");
            GameObject e = Instantiate(animation) as GameObject;
            e.transform.position = transform.position;
            
        }
    }
}
