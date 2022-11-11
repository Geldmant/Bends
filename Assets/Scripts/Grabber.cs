using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    public bool isGrab = false;
    public Transform hand, player;
    public float pickUpDist;
    public float pickUpSpeed;


    void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward * pickUpDist);
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * pickUpDist, Color.red);

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, pickUpDist))
            {
            }

            if (hit.collider.GetComponent<CanGrabb>())
            {
                Vector3 a = hit.transform.position;
                Vector3 b = hand.position;

                hit.transform.position = Vector3.Lerp(a, b, pickUpSpeed);
                hit.transform.SetParent(hand);
                hit.collider.GetComponent<Rigidbody>().isKinematic = true;
            }
            isGrab = true;
        }
        else
        {
            isGrab = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit, pickUpDist))
            {
                if (hit.collider.GetComponent<Door>())
                {
                    Door door = GetComponent<Door>();
//                    player.position = door.doorLeavePos; //тп к позиции выхода двери
                    
                }
            }
        }
    }
}
