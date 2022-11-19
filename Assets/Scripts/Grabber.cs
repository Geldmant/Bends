using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Grabber : MonoBehaviour
{
    public float pickUpDist;
    public TextMeshProUGUI txt, txt2;
    public Transform player;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
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
                    rb.AddForce(Vector3.up * 200f);
                    Debug.Log("Предмет подобран: " + hit.collider.GetComponent<CanGrabb>().id);
                }
            }
            else txt.text = "";

            if (hit.collider.GetComponent<Door>())
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Door doorPos = hit.collider.GetComponent<Door>();

                    player.position = doorPos.doorLeavePos.position;
                    Debug.Log("Teleport");
                    
                }
                txt2.text = "Зайти E: ";
            }
            else txt2.text = "";

        }
    }
}
