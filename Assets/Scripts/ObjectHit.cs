using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //when something collides with the object this script is attached to
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Bumped into a wall");
    }


}
