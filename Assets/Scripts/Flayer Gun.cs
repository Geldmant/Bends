using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlayerGun : MonoBehaviour
{
    public GameObject Bullet;
    public int Ammo = 1;
    public float force;
    public Transform dulo;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Ammo >= 1)
        {
            Instantiate(Bullet, Vector3.forward, Quaternion.identity, dulo);
            //this.Bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }
        if (Input.GetKeyDown(KeyCode.R) && Ammo == 0)
            Ammo = 1;
    }
}
