using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour
{

    public Vector2 MousePosition;
    public float Sensitivity = 0.7f;
    public ParticleSystem WaterParticles;
    public AudioSource AudioSource;
    

    private void MouseControl()
    {
        MousePosition.x += Input.GetAxis("Mouse X") * Sensitivity;
        MousePosition.x = Mathf.Clamp(MousePosition.x, -90f, 90);

        MousePosition.y -= Input.GetAxis("Mouse Y") * Sensitivity;
        MousePosition.y = Mathf.Clamp(MousePosition.y, 330, 370f);

        transform.localRotation = Quaternion.Euler(MousePosition.y, MousePosition.x, 0f);

    }

    private void Fire()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            WaterParticles.Play();
            AudioSource.mute = false;
        }
        else
        {
            WaterParticles.Stop();  
            AudioSource.mute = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        MouseControl();
        Fire();
    }
}
