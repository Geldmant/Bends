using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool isMenuActive = false;
    public GameObject menu;
    public GameObject player;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isMenuActive != true)
            {
                isMenuActive = true;
                menu.SetActive(true);
                player.GetComponent<FirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = false;
                player.GetComponent<FirstPersonController>().lockCursor = false;
            }
            else
            {
                isMenuActive = false;
                menu.SetActive(false);
                player.GetComponent<FirstPersonController>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = true;
                player.GetComponent<FirstPersonController>().lockCursor = true;
            }
            
        }
    }

    public void Resume()
    {
        isMenuActive = false;
        menu.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        player.GetComponent<FirstPersonController>().lockCursor = true;
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
