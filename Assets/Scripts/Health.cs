using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame

    public int health,maxhealth;
    public int damage;
    public int heal;
    public TextMeshProUGUI HealthBar;
    public Slider sl;
    public HudScript HS;
    public int PressureDamage;

    private void Start()
    {
        HS = HS.GetComponent<HudScript>();
       
    }


    void Update()
    {

        sl.value = health;

        HealthBar.text = "HP "+health    ; 


        if (health >= maxhealth)
       {
            health = maxhealth;
        }


        if (health <= 0)
        {
            
            Debug.Log("You Died.");

        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            health -= damage;
        }
        if (Input.GetKeyUp(KeyCode.Keypad6))
        {
            health += heal;

        }



        
    }
}
