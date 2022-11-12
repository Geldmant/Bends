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
            transform.Translate(Vector3.right * ad * runSpeed);     //���� � ������(���)
            transform.Translate(Vector3.forward * ws * runSpeed);
        }
        else
        {
            transform.Translate((Vector3.right * ad) * speed);        //���� ��� �����(������)
            transform.Translate((Vector3.forward * ws) * speed);
        }
      
    }
}
