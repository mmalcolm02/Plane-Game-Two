using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellarSpin : MonoBehaviour
{
    //defining the speed the propeller moves at
    private float propellerSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform for propeller vector set to framerate as speed has no impact on gameplay
        transform.Rotate(Vector3.forward, propellerSpeed);
    }
}
