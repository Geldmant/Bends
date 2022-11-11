using UnityEngine;

public class CanGrabb : MonoBehaviour
{
    public Grabber grab;


    private void Update()
    {
        if(grab.isGrab == false)
        {
            transform.SetParent(null);
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
