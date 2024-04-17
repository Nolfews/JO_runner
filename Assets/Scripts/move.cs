using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float jumpHeight = 7f;
    public bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
    if (isGrounded) {
        if (Input.GetButtonDown("Jump"))
            rb.AddForce(Vector3.up * jumpHeight)
    }
    if (Input.GetKey(KeyCode.A))
        transform.Translate(-0.1f, 0f, 0f);
    if (Input.GetKey(KeyCode.D))
        transform.Translate(0.1f, 0f, 0f);
    if (Input.GetKey(KeyCode.W))
        transform.Translate(0f, 0f, 0.1f);
    if (Input.GetKey(KeyCode.S))
        transform.Translate(0f, 0f, -0.1f);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
            isGrounded = true;
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
            isGrounded = false;
    }
}
