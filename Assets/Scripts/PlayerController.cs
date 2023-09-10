using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float turnSpeed = 25;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float Horizontalinput = Input.GetAxisRaw("Horizontal");

        float ForwardInput = Input.GetAxisRaw("Vertical");

        //Mpove the car based on vertical input 

        transform.Translate(Vector3.forward*Time.deltaTime*turnSpeed*ForwardInput);

        // Rotate the car based on horizontal Inputs
        transform.Rotate(Vector3.forward ,turnSpeed*Horizontalinput*Time.deltaTime);
    }
}
