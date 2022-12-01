using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlayerGun : MonoBehaviour
{
    public GameObject Bullet;
    public int Ammo;
    [Tooltip("Кол-во патрон после перезарядки")] public int Magazine;
    public float force, reloadTime ,shootTime;
    public Transform dulo;
    private Animator anim;
    [SerializeField] private bool isFullyLoad, canShoot;

    void Start() 
    {
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Ammo >= 1 && isFullyLoad && canShoot)
        {
            StartCoroutine(shoot());
            Shoot();
            canShoot = false;
        }
            

        if (Input.GetKeyDown(KeyCode.R) && Ammo <= 0)
        {
            Reload();
            StartCoroutine(reload());
            isFullyLoad = false;
        }
    }
    void Shoot()
    {
        Transform BulletInstance = (Transform)Instantiate(Bullet.transform, dulo.position, Quaternion.identity);
        BulletInstance.GetComponent<Rigidbody>().AddForce(-transform.right * force);
        Ammo -= 1;
        anim.SetTrigger("shooting");
    }

    void Reload()
    {
        Ammo = Magazine;
        anim.SetTrigger("reloading");
    }
    private IEnumerator reload()
    {
        yield return new WaitForSeconds(reloadTime);
        isFullyLoad = true;
    }
    private IEnumerator shoot()
    {
        yield return new WaitForSeconds(shootTime);
        canShoot = true;
    }
}
