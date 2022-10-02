using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScene : MonoBehaviour
{
    public void LoadNewScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PlanetScene");     
    }
}
