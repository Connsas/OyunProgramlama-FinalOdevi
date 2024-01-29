using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBetweenCameras : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject FireCamera;
    public GameObject MainCamera;

    private void ChangeCamera()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (FireCamera.activeSelf)
            {
                FireCamera.SetActive(false);
                MainCamera.SetActive(true);
            }
            else
            {
                FireCamera.SetActive(true);
                MainCamera.SetActive(false);
            }
        }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCamera();
    }
}
