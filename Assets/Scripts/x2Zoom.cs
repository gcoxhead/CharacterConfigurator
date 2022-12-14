using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2Zoom : MonoBehaviour
{
    public Camera cam;
    public float defaultFov = 90;
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            cam.fieldOfView = (defaultFov / 2);
        }
        else
        {
            cam.fieldOfView = (defaultFov);
        }
    }
}
