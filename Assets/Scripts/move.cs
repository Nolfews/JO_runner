using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-0.1f, 0f, 0f);
        if (Input.GetKey(KeyCode.A) && transform.position.z > -4)
            transform.Translate(0f, 0f, -0.1f);
        if (Input.GetKey(KeyCode.D) && transform.position.z < 4)
            transform.Translate(0f, 0f, 0.1f);
    }
}
