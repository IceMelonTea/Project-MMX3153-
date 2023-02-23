using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpforce = 1000f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("s"))
        {
            transform.position -= transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("a"))
        {
            transform.position -= transform.right * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            {
          
            }
        }
    }
}
