using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCameraScript : MonoBehaviour
{
    public GameObject Vehicle;
     Vector3 offset = new Vector3(-0.07f, 7.8f, -10.7f);

    //public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = Vehicle.transform.position + offset;
    }
 
    }

