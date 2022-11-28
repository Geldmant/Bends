using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlayerGun : MonoBehaviour
{
    public GameObject Bullet;
    public int Ammo;
    [Tooltip("Кол-во патрон после перезарядки")] public int Magazine;
    public float force;
    public Transform dulo;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Ammo >= 1)
        {
            Debug.Log("Shoot");
            Ammo -= 1;
            Instantiate(Bullet, dulo.position, Quaternion.Euler(this.transform.right));
        }
        if (Input.GetKeyDown(KeyCode.R) && Ammo <= 0)
            Ammo = Magazine;
    }
}
