using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step : MonoBehaviour
{
    public AudioSource footstepsSound, SprintSound;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false; 
                SprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true; 
                SprintSound.enabled = false;
            }
        }    
        else
        {
           footstepsSound.enabled = false; 
           SprintSound.enabled = false; 
        }
    }
}
