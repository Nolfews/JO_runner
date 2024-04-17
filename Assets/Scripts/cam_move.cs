using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_move : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Cursor.lockstate = lockmode.lock;
        // cursor.visible = true;
        if(Input.GetAxis("Mouse X") < 0)
            transform.Rotate(0f, 1f, 0);
        if(Input.GetAxis("Mouse X") > 0)
            transform.Rotate(0f, -1f, 0f);
        if(Input.GetAxis("Mouse Y") < 0)
            transform.Rotate(1f, 0f, 0f);
        if(Input.GetAxis("Mouse Y") > 0)
            transform.Rotate(-1f, 0f, 0f);
    }
}
