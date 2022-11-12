using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cam;
    public PlayerController pl;
    [Range(50, 200)]public float sensitivity;
    private float xRotation = 0f;

    void Update()
    {
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;

        xRotation = y;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        pl.player.transform.Rotate(Vector3.up * x);
        cam.transform.Rotate(Vector3.right * xRotation);
    }
}
