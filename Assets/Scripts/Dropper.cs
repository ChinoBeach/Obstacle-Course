using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //cache a mesh renderer to gain access to it
    MeshRenderer renderer;
    //cache a rigid body
    Rigidbody rigidBody;

    //X seconds that we are waitng for
    [SerializeField] float flt_waitTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //instanciate the renderer
        renderer = GetComponent<MeshRenderer>();
        //disable the renderer to make the object invisable
        renderer.enabled = false;

        //instanciate the rigid body(purpose: being able to access gravity so that we can make the object fall when we want)
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if more than X seconds have passed
        if(Time.time > flt_waitTime)
        {
            //Debug.Log(flt_waitTime + " seconds have elapsed");
           
            //Make the object visable
            renderer.enabled = true;

            //Make the object have gravity(make it fall if its in the air)
            rigidBody.useGravity = true;
        }
        
    }
}
