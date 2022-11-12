using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    [Tooltip("�������� ���������")]
    [Range(0,1)] public float speed, runSpeed;      //��������


    void FixedUpdate()
    {
        float ws = Input.GetAxis("Vertical");       //��������� ������
        float ad = Input.GetAxis("Horizontal");


        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate((player.transform.right * ad) * runSpeed);     //���� � ������(���)
            transform.Translate((player.transform.forward * ws) * runSpeed);
        }
        else
        {
            transform.Translate((player.transform.right * ad) * speed);        //���� ��� �����(������)
            transform.Translate((player.transform.forward * ws) * speed);
        }

    }
}
