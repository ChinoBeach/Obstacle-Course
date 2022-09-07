using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //X seconds that we are waitng for
    [SerializeField] float flt_waitTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if more than X seconds have passed
        if(Time.time > flt_waitTime)
        {
            Debug.Log(flt_waitTime + " seconds have elapsed");
        }
        
    }
}
