using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Rigidbody javelot;
    public float speed = 75;
    public bool finish = false;
    private bool shoot = false;

    public Camera cameraGame;
    public Camera cameraEnd;

    void Start()
    {
        cameraEnd.enabled = false;
    }
    void Update()
    {
        if (finish == false)
            transform.Translate(-10f * Time.deltaTime, 0f, 0f);
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.z > -4)
            transform.Translate(0f, 0f, -25f * Time.deltaTime);
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.z < 4)
            transform.Translate(0f, 0f, 25f * Time.deltaTime);

        if (finish == true && shoot == false) {
            Rigidbody instantiatedProjectile = Instantiate(javelot, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(-speed, 30, 0));
            instantiatedProjectile.transform.Rotate(90, 0, 0);
            shoot = true;
            cameraEnd.enabled = true;
            cameraGame.enabled = false;
        }
    }
}
