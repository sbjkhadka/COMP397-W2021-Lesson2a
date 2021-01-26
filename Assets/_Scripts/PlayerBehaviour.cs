using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public float jumpForce;
    public Rigidbody rigidBody;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded)
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

            if (Input.GetAxisRaw("Vertical") > 0)
            {
                // move forward
                rigidBody.AddForce(Vector3.forward * movementForce);

            }

            if (Input.GetAxisRaw("Vertical") < 0)
            {
                // move backward
                rigidBody.AddForce(Vector3.back * movementForce);
            }

            if (Input.GetAxisRaw("Jump") > 0)
            {
                // Jump
                rigidBody.AddForce(Vector3.up * jumpForce);
            }

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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground")) 
        {
            isGrounded = true;
        }
    }
        

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
