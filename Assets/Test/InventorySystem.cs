using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public GameObject[] itemSlots;
    public Camera cam;


    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetKey(KeyCode.Mouse0) && hit.collider.GetComponent<invGrab>())
            {
                hit.collider.GetComponent<invGrab>().transform.position = Input.mousePosition;

            }
        }
    }
}
