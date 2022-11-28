using UnityEngine;

public class Ammo : MonoBehaviour
{
    private FlayerGun fl;
    public Rigidbody rb;
    public GameObject ammo;

    void Start()
    {
        fl = GetComponent<FlayerGun>();

        rb.AddForce(Vector3.forward * fl.force);
        Destroy(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.isKinematic = true;
    }
}
