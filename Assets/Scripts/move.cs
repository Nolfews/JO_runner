using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-10f * Time.deltaTime, 0f, 0f);
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.z > -4)
            transform.Translate(0f, 0f, -25f * Time.deltaTime);
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.z < 4)
            transform.Translate(0f, 0f, 25f * Time.deltaTime);
    }
}
