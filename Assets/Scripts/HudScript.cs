using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HudScript : MonoBehaviour
{
    public TextMeshProUGUI barom;
    public float alt, barometre = 0f, oxygen = 200f, O2Divider;
    public Transform player;
    public GameObject arrBar, arrO2;
    public LayerMask lay;
    

    void Update()
    {
        Ray ray = new Ray(player.position, player.up);
        Debug.DrawRay(player.position, player.up * 10000f, Color.yellow);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 10000f, lay))
        {
            barometre = hit.distance;

        }

        barometre = barometre + alt;
        barom.text = "ְעלמספונ " + Mathf.Floor(barometre);
        arrBar.transform.rotation = Quaternion.Lerp(arrBar.transform.rotation, Quaternion.Euler(0, 0, barometre), Time.deltaTime);

        arrO2.transform.rotation = Quaternion.Lerp(arrO2.transform.rotation, Quaternion.Euler(0, 0, -oxygen), Time.deltaTime);
        while (oxygen <= 0f)
        {
            oxygen -= O2Divider;
        }

    }
}
