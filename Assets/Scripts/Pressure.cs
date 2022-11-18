using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pressure : MonoBehaviour
{
    public HudScript HS;
    public Health HP;
    public int DangerPressure;
    [Header("А и Б сидели на трубе...")]
    public int a = 1, b = 1;

    void Start()
    {
        HP = HP.GetComponent<Health>();
        HS = HS.GetComponent<HudScript>();

    }

    void FixedUpdate()
    {
        if (HS.barometre > DangerPressure)
        {
            if(a == 1)
            {
                StartCoroutine(SS());
                a = 0;
                b = 1;
                Debug.Log("Start");
            }

        }
        if (HS.barometre < DangerPressure)
        {
            if (a == 0)
            {
                StopCoroutine(SS());
                a = 1;
                b = 0;
                Debug.Log("Stop");
            }

        }

    }
    public IEnumerator SS()
    {
        do
        {
            HP.health -= HP.PressureDamage;
            yield return new WaitForSeconds(1f);

        } while (b == 1);
    }
}

