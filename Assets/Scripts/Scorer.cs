using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //Variables 
    int int_numTimesHit = 0;

    //If something hits the player or the player hits something
    private void OnCollisionEnter(Collision other)
    {
        //incremenet number of times hit something
        int_numTimesHit++;
        
        //Tell the consol how many times you have hit something
        Debug.Log("You've bumped into a thig this many times: " + int_numTimesHit);
        
    }
}
