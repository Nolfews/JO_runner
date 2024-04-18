using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            player Player = FindObjectOfType<player>();
            Player.jav_size += 1;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(0f, 0f, 75f * Time.deltaTime);
    }
}
