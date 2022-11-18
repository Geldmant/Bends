using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pressure : MonoBehaviour
{
    public HudScript HS;
    public Health HP;
    public int DangerPressure;

    void Start()
    {
        HP = HP.GetComponent<Health>();
        HS = HS.GetComponent<HudScript>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(SS());

        }

    }
    public IEnumerator SS()
    {
        while (true)
        {
            HP.health -= 5;
            yield return new WaitForSeconds(1f);

        }
    }
}

