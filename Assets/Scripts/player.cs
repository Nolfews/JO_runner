using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Rigidbody javelot;
    public float throwspeed = 10;
    public bool finish = false;
    private bool shoot = false;

    public Camera cameraGame;
    public Camera cameraEnd;
    public GameObject handjav;

    public int jav_size = 1;

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
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(-throwspeed, 15, 0));
            instantiatedProjectile.transform.Rotate(90, 0, 0);
            instantiatedProjectile.transform.localScale = new Vector3(0.2f, 1 * jav_size, 0.2f);
            instantiatedProjectile.transform.position = new Vector3(-245, 8, 0);
            shoot = true;
            cameraEnd.enabled = true;
            cameraGame.enabled = false;
            Destroy(handjav);
        }
        if (finish == false)
            handjav.transform.localScale = new Vector3(0.1f, 1 * jav_size, 0.1f);
    }
}
