using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{

    public float speed = -0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Storages.stop)
        {
            Vector2 offset = new Vector2((Time.time * speed) * -1, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }

    }
}
