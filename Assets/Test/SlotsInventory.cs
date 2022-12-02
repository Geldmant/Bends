using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsInventory : MonoBehaviour
{
    public bool isFool;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        isFool = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isFool = false;
    }
}
