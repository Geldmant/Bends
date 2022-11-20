using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool isMenuActive = false;
    public GameObject MenuPanel;
    public GameObject player;
    public GameObject DeathScreen, Camera, GUI;
    public Health Health;
   
    public Transform respawn;

    public void Update()
    {

        if (Health.health <= 0)
        {

            

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            player.GetComponent<PlayerController>().enabled = false;
            DeathScreen.SetActive(true);
            Camera.GetComponent<PostProcessVolume>().enabled = false;
            Camera.GetComponent<CameraController>().enabled = false;
            GUI.SetActive(false);
            Health.health = Health.maxhealth;

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            

            if(isMenuActive != true)
            {
                isMenuActive = true;
                MenuPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                player.GetComponent<PlayerController>().enabled = false;
                Camera.GetComponent<CameraController>().enabled = false;
            }
            else
            {
                isMenuActive = false;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                player.GetComponent<PlayerController>().enabled = true;
                Camera.GetComponent<CameraController>().enabled = true;
            }
            
        }
    }

    public void ResumeTheGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.GetComponent<PlayerController>().enabled = true;
        DeathScreen.SetActive(false);
        Camera.GetComponent<PostProcessVolume>().enabled = true;
        Camera.GetComponent<CameraController>().enabled = true;
        GUI.SetActive(true);
        player.transform.position = respawn.position;
        Debug.Log("Игрок воскрес");
    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        MenuPanel.SetActive(false);
        player.GetComponent<PlayerController>().enabled = true;
        Camera.GetComponent<CameraController>().enabled = true;
        
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
