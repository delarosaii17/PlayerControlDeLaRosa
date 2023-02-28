using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    private Camera myCamera;
    // Start is called before the first frame update
    void Start()
    {
        myCamera = GetComponent<Camera>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myCamera.enabled = !myCamera.enabled;
        }
    }
}
