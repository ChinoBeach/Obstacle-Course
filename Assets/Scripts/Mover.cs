using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Start off by moving 1 space first
        transform.Translate(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //allow us to change the transform value every frame
        transform.Translate(0.01f, 0f, 0f);
    }
}
