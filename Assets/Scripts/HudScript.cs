using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HudScript : MonoBehaviour
{
    public TextMeshProUGUI barom;
    public float alt, barometre = 0f;
    public Transform player;
    public GameObject clock;
    public LayerMask lay;


    void Update()
    {
        Ray ray = new Ray(player.position, -player.up);
        Debug.DrawRay(player.position, -player.up * 1000f, Color.yellow);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000f, lay))
        {
            barometre = hit.distance;

        }

        barometre = barometre + alt;
        barom.text = "ְעלמספונ " + Mathf.Floor(barometre);
        clock.transform.rotation = Quaternion.Lerp(clock.transform.rotation, Quaternion.Euler(0, 0, barometre), Time.deltaTime);

    }
}
