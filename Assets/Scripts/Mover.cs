using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Varialbles for user movement and speed
    [SerializeField] float flt_moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Get input for x, and z variables,make it frame rate independent, and give it the correct speed
        float flt_xValue = Input.GetAxis("Horizontal") * Time.deltaTime * flt_moveSpeed;
        float flt_zValue = Input.GetAxis("Vertical") * Time.deltaTime * flt_moveSpeed;
        //we dont want our player to fly
        float flt_yValue = 0;

        //allow us to change the transform value every frame(moves the player)
        transform.Translate(flt_xValue, flt_yValue, flt_zValue);
    }
}
