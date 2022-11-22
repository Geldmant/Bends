using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("�������")]

    public GameObject pl;
    public Camera camer;

    [Header("�����")]

    [Range(0.1f, 40)] public float sensitivity;
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

        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        pl.transform.Rotate(Vector3.up, x * sensitivity);
        transform.Rotate(-Vector3.right, y * sensitivity);
    }
}
