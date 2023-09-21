using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //speed changed to a reasonable level testing with public float first
    public float speed = 0.3f;
    //rotationSpeed changed to a reasonable level testing with public float first
    public float rotationSpeed = 50;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate fixed Vector to move plane forwards
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys - vertical input inserted for interactivity
        transform.Rotate(Vector3.right, verticalInput * rotationSpeed * Time.deltaTime);
    }
}
