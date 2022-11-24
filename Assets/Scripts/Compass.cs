using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public float numMultiplay;
    public Transform arrBar;
    public HudScript hScr;
    public bool isBarNoOxygen = true;
    

    void Update()
    {
        if(isBarNoOxygen)
        arrBar.rotation = Quaternion.Lerp(arrBar.rotation, Quaternion.Euler(-Vector3.forward * (hScr.barometre * numMultiplay)), 1f);
            else
            arrBar.rotation = Quaternion.Lerp(arrBar.rotation, Quaternion.Euler(-Vector3.forward * (hScr.oxygen * numMultiplay)), 1f);

    }
}
