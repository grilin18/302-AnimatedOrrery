using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigScript : MonoBehaviour
{
    // The tilt of the camera in degress
    private float pitch = 20;
    private float yaw = 0;
    private float roll = 0;
    private float dollyDis = 30;
    private float targetDollyDis = 20;

    public float mouseSensitivityY = 5;
    public float mouseSensitivityX = 5;
    public float mouseScrollMult = 50;

    public GameObject Sun;
    public GameObject Planet1;
    public GameObject Planet2;
    public GameObject Planet3;
    public GameObject Planet4;
    public GameObject Planet5;
    private Vector3 target;

    public int lookAtValue = 0;
    public bool doOnce = true;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        lookAtPlanet();

        transform.position = AnimMath.Slide(transform.position, target, .05f);

        if (Input.GetButton("Fire2"))
        {
            float mouseY = Input.GetAxis("Mouse Y");
            float mouseX = Input.GetAxis("Mouse X");

            pitch -= mouseY * mouseSensitivityY;
            yaw += mouseX * mouseSensitivityX;
        }

        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");

        targetDollyDis -= scroll * mouseScrollMult;
        targetDollyDis = Mathf.Clamp(targetDollyDis, 4, 30);

        dollyDis = AnimMath.Slide(dollyDis, targetDollyDis, .05f); // EASE

        cam.transform.localPosition = new Vector3(0, 0, -dollyDis);

        // changing rotation to match the pitch variable:
        pitch = Mathf.Clamp(pitch, -89, 89);

        Quaternion targetRotation = Quaternion.Euler(pitch, yaw, roll);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.05f); // EASE
    }
    void lookAtPlanet()
    {
        if (lookAtValue == 0)
        {
            target = Sun.transform.position;
            if (doOnce)
            {
                targetDollyDis = 30;
                doOnce = false;
            }
        }
        else if (lookAtValue == 1)
        {
            target = Planet1.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
        else if (lookAtValue == 2)
        {
            target = Planet2.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
        else if (lookAtValue == 3)
        {
            target = Planet3.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
        else if (lookAtValue == 4)
        {
            target = Planet4.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
        else if (lookAtValue == 5)
        {
            target = Planet5.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
    }
}
