using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pressure : MonoBehaviour
{

    public Health HP;
    public HudScript HS;
    public int DangerPressure;
    public bool OK = true;

    void Start()
    {
        HP = HP.GetComponent<Health>();
        HS = HS.GetComponent<HudScript>();





    }
    void Update()
    {
        if (HS.barometre >= DangerPressure && OK == true)
        {
            StartCoroutine(Time());
            OK = false;
        } 
       
    }
    public IEnumerator Time()
    {
        while (true)
        {
            HP.health -= HP.PressureDamage;
            yield return new WaitForSeconds(5f);

        }

    




        
    }                                                               
   
    

}

