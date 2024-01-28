using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    void Update()
    {
      if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadSceneAsync(0);
            }  
    }
}
