using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public float lolofest = 0f;
    public Transform arrBar, from;
    public HudScript hScr;
    

    void Update()
    {
        arrBar.rotation = Quaternion.Lerp(from.rotation, Quaternion.Euler(Vector3.up * lolofest), 1f);


    }
}
