using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsInventory : MonoBehaviour
{
    public bool isFull;


    private void OnTriggerEnter(Collider other)
    {
        isFull = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isFull = false;
    }
}
