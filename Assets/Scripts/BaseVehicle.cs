using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseVehicle : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float turnSpeed;
    float horizontalInput;
    float forwardInput;
    float xRange = 5.5f;
    float topBound = 5f;
    float bottomBound = -3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        /* Getting player input */
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 

        /* Move the vehicle forward/backward */
        transform.Translate(Vector3.up * Time.deltaTime * speed * forwardInput);

        /* Turn and move the vehicle right/left */
        transform.Rotate(Vector3.forward, Time.deltaTime * turnSpeed * horizontalInput);

        /* Bound the vehicle to the parking area */
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, bottomBound, transform.position.z);
        }
        if(transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, transform.position.z);
        }
    }

}
