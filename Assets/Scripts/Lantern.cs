using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{
    public float intensit;
    public GameObject lamp;
    public Light lighte;

    void Update()
    {
        lighte.intensity = intensit;

        if (lamp.activeSelf == true && intensit <= 20)
            intensit++;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //проиграть анимацию прицела

        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            //проиграть реверснутую анимацию прицела

        }

    }
}
