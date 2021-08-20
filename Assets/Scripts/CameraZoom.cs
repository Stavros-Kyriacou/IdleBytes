using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private float zoomChange;
    [SerializeField] private float smoothChange;
    [SerializeField] private float minSize, maxSize;
    private Camera mainCam;

    private void Awake()
    {
        mainCam = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            mainCam.orthographicSize -= zoomChange * Time.deltaTime * smoothChange;
            mainCam.orthographicSize = Mathf.Clamp(mainCam.orthographicSize, minSize, maxSize);
        }
        if (Input.mouseScrollDelta.y < 0)
        {
            mainCam.orthographicSize += zoomChange * Time.deltaTime * smoothChange;
            mainCam.orthographicSize = Mathf.Clamp(mainCam.orthographicSize, minSize, maxSize);
        }

    }


}
