using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsInventory : MonoBehaviour
{
    public bool isFull;
    public float num;

    void Update()
    {
        transform.rotation.y = num;
    }
    private void OnTriggerEnter(Collider other)
    {
        isFull = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isFull = false;
    }
}
