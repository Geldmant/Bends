using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pressure : MonoBehaviour
{

    public Health HP;
    public HudScript HS;
    public int DangerPressure;
    public bool TakeDamage;

    void Start()
    {
        HP = HP.GetComponent<Health>();
        HS = HS.GetComponent<HudScript>();
        
    }                                                               
    void Update()
    {
        if (HS.barometre >= DangerPressure)
        {
            for()
            {
                HP.health -= HP.damage;
            }

        }
    }
}
