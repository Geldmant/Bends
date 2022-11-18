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
        Fart();
        

    }                                                               
    void Update()
    {
        
        
    }

    public void Fart()
    {
        if(HP.barometre >= DangerPressure)
        {
            HP.health -= HP.damage
            

        }
        yield return new WaitForSeconds(5)
    }

   

}
