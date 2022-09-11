using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    //variables for rotations
    [SerializeField] float flt_xAngle = 0;
    [SerializeField] float flt_yAngle = 0;
    [SerializeField] float flt_zAngle = 0;
    // Update is called once per frame
    void Update()
    {
        //rotate this object
        transform.Rotate(flt_xAngle,flt_yAngle,flt_zAngle);
    }
}
