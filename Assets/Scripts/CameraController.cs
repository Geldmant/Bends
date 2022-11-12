using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("�������")]

    public GameObject pl;
    public Camera camer;

    [Header("�����")]

    [Range(50, 200)] public float sensitivity;
    [Range(1, 120)] public float FOV;
    [Header("�������")]

    public bool hideCursor = true;

    private void Start()
    {
    if (hideCursor)
        {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        }
    }

    void Update()
    {
        camer.fieldOfView = FOV;

        float x = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;

        y = Math.Clamp(y, -90f, 90f);

        pl.transform.Rotate(Vector3.up * x);
        transform.Rotate(-Vector3.right * y);
    }
}
