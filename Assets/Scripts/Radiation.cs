using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;     //“ут

public class Radiation : MonoBehaviour
{
    public GameObject DangerThing;
    public float Distance, DangerDistance;
    public PostProcessVolume ppv;       //“ут

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("»грок вошЄл в триггер");
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            DangerThing.transform.LookAt(other.GetComponent<PlayerController>().transform);

        }

    }
    public void Update()
    {
        Ray ray = new Ray(DangerThing.transform.position, DangerThing.transform.forward); ;
        RaycastHit hit;
        Debug.DrawRay(DangerThing.transform.position, DangerThing.transform.forward * Distance, Color.green);
        if (Physics.Raycast(ray, out hit, Distance))
        {
            DangerDistance = hit.distance;
            ppv.weight = 1f;        //“ут
        }
    }
}
