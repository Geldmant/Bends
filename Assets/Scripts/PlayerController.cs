using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    [Tooltip("Скорость персонажа")]
    [Range(0,1)] public float speed, runSpeed;      //Скорость


    void FixedUpdate()
    {
        float ws = Input.GetAxis("Vertical");       //Упраление персом
        float ad = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.right * ad * runSpeed);     //Если с шифотм(бег)
            transform.Translate(Vector3.forward * ws * runSpeed);
        }
        else
        {
            transform.Translate((Vector3.right * ad) * speed);        //Если без шифта(ходьба)
            transform.Translate((Vector3.forward * ws) * speed);
        }
      
    }
}
