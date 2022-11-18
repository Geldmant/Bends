using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radiation : MonoBehaviour
{
    public GameObject DangerThing;
    public float Distance, DangerDistance;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Игрок вошёл в триггер");
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            DangerThing.transform.LookAt(other.GetComponent<PlayerController>().transform);

        }

    }
    private void Update()
    {
        Ray ray = new Ray(DangerThing.transform.position, DangerThing.transform.forward); ;
        RaycastHit hit;
        Debug.DrawRay(DangerThing.transform.position, DangerThing.transform.forward * Distance, Color.green);
        if (Physics.Raycast(ray, out hit, Distance))
        {
            DangerDistance = hit.distance;
        
        }
    }
}
