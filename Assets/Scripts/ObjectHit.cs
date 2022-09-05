using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //when something collides with the object this script is attached to
    private void OnCollisionEnter(Collision other)
    {
        

        //tell the consol that a wall was hit
        Debug.Log("Bumped into a wall");

        //change the color of the wall
        GetComponent<MeshRenderer>().material.color = Color.gray;

    }


}
