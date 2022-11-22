using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HudScript : MonoBehaviour
{
    public TextMeshProUGUI barom;
    public float alt, barometre, oxygen = 200f, O2Divider;
    public Transform player;
    public Transform arrBar, arrO2;
    public LayerMask lay;

    public float barRot = 200f / 20f;
    void Update()
    {
        Ray ray = new Ray(player.position, player.up);
        Debug.DrawRay(player.position, player.up * 10000f, Color.yellow);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 10000f, lay))
        {
            barometre = hit.distance;
        }

        barometre += alt;
        barom.text = "ְעלמספונ " + Mathf.Round(barometre);
        arrBar.localRotation = Quaternion.Euler(arrBar.forward * barRot);

        //arrO2.transform.rotation = ;

    }
}
