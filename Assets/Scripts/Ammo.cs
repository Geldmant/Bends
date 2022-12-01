using UnityEngine;

public class Ammo : MonoBehaviour
{
    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        rb.isKinematic = true;
        Destroy(this.gameObject, 7f);
    }
}
