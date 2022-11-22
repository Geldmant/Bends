using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject backpack;
    [SerializeField]
    private bool isOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!isOpen)
            {
                backpack.SetActive(true);       //Открытие рюкзака
                isOpen = true;
            }
            if (isOpen)
            {
                backpack.SetActive(false);      //Закрытие рюкзака
                isOpen = false;
            }
        }
    }
}
