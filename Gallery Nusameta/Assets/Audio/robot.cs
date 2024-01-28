using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour
{
    public AudioSource BeepSound;

    bool audioPlayed = false;
    float distance;

    public GameObject player;

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        if(distance <= 4.0f)
        {
                if (Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Mouse0) && !audioPlayed)
            {
                BeepSound.Play();
                audioPlayed = true;
            }
            else
            {
                audioPlayed = false;
            }
        }
        
    }
}
