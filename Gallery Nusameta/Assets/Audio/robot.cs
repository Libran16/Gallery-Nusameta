using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour
{
    public AudioSource BeepSound;

    bool audioPlayed = false;
    float distance;
    float curResponseTracker = 0;

    public GameObject player;

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        if(distance <= 4.7f)
        {
                if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Return) && !audioPlayed)
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
