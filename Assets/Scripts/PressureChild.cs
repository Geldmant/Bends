using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureChild : MonoBehaviour
{
    public Health HP;
    public Pressure scr;

    public void Start()
    {
        HP.health -= 5;

        Invoke("UnActive()", 2f);

    }

    public void UnActive()
    {
        scr.enabled = false;
    }
}
