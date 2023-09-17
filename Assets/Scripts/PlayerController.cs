using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
   public float turnspeed = 45f;
    float HorizontalInput;
    float VerticalInput;
    public void Start()
    {



    }


     void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        // we will move the vehicle in forward direction.
        transform.Translate(Vector3.forward * speed * Time.deltaTime * VerticalInput);// vectro3.forward = (0,0,1);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * HorizontalInput);// vector3.up = (0,1,0);


    }

}



    
