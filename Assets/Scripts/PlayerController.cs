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
    public GameObject[] hotTools;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            hotTools[0].SetActive(true);
            hotTools[1].SetActive(false);
            hotTools[2].SetActive(false);
            hotTools[3].SetActive(false);
            hotTools[4].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            hotTools[0].SetActive(false);
            hotTools[1].SetActive(true);
            hotTools[2].SetActive(false);
            hotTools[3].SetActive(false);
            hotTools[4].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            hotTools[0].SetActive(false);
            hotTools[1].SetActive(false);
            hotTools[2].SetActive(true);
            hotTools[3].SetActive(false);
            hotTools[4].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            hotTools[0].SetActive(false);
            hotTools[1].SetActive(false);
            hotTools[2].SetActive(false);
            hotTools[3].SetActive(true);
            hotTools[4].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            hotTools[0].SetActive(false);
            hotTools[1].SetActive(false);
            hotTools[2].SetActive(false);
            hotTools[3].SetActive(false);
            hotTools[4].SetActive(true);
        }
    }

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
