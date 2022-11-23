using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    public GameObject drill, particles;
    public float rotateSpeed = 10f;


    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Quaternion rotF = Quaternion.AngleAxis(rotateSpeed, Vector3.forward);
            drill.transform.rotation *= rotF;
            particles.SetActive(true);
            
        }
        else particles.SetActive(false);
    }
}
