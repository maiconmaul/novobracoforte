using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSceneScript : MonoBehaviour
{
    public void LoadNewScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PlanetScene");        
    }
}
