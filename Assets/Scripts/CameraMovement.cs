using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 origin;
    private Vector3 distance;
    private bool drag = false;
    private Camera mainCam;
    private void Awake()
    {
        mainCam = GetComponent<Camera>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            distance = (mainCam.ScreenToWorldPoint(Input.mousePosition)) - mainCam.transform.position;
            if (!drag)
            {
                drag = true;
                origin = mainCam.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        else
        {
            drag = false;
        }

        if (drag)
        {
            mainCam.transform.position = origin - distance;
        }

        
    }
}
