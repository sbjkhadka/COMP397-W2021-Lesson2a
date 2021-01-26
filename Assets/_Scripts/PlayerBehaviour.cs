using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            // move right
            rigidBody.AddForce(Vector3.right * movementForce);

        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            // move left
            rigidBody.AddForce(Vector3.left * movementForce);
        }


        // Debugging Input.GetAxixRaw()..
        //if (Input.GetAxisRaw("Horizontal") > 0) 
        //{
        //    // move right
        //    Debug.Log("Moving right");

        //}

        //if (Input.GetAxisRaw("Horizontal") < 0) 
        //{
        //    Debug.Log("Moving Left");
        //    // move left
        //}
    }
}
