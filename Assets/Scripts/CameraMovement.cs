using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float minDistance, maxDistance;
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
            mainCam.transform.position = new Vector3(Mathf.Clamp(mainCam.transform.position.x, minDistance, maxDistance), Mathf.Clamp(mainCam.transform.position.y, minDistance, maxDistance), -10);
        }
    }
}
