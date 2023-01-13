using UnityEngine;

public class Slotsinv : MonoBehaviour
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
