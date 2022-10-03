using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initConf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Storages.MainSpaceShip == null)
        {
            Storages.MainSpaceShip = new SpaceShip(4, 4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
