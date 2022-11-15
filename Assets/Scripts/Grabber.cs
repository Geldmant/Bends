using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Grabber : MonoBehaviour
{
    public float pickUpDist;
    public TextMeshProUGUI txt;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward * pickUpDist);
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * pickUpDist, Color.red);

        if (Physics.Raycast(ray, out hit, pickUpDist))
        {
            if (hit.collider.GetComponent<CanGrabb>())
            {
                txt.text = "Подобрать E: " + hit.collider.GetComponent<CanGrabb>().id;
                Rigidbody rb =  hit.collider.GetComponent<Rigidbody>();

                if (Input.GetKeyDown(KeyCode.E))
                {
                    rb.AddForce(Vector3.up * 300f);
                    Debug.Log("Предмет подобран");
                }
            }       
            else
                txt.text = "";
        }   
    }
}
