using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Variables
    [SerializeField]float flt_xValue = 0f;
    [SerializeField]float flt_yValue = 0.1f;
    [SerializeField]float flt_zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //allow us to change the transform value every frame
        transform.Translate(flt_xValue, flt_yValue, flt_zValue);
    }
}
