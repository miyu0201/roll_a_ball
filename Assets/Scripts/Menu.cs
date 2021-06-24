using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject canvasMenu;

    public Button ButtonStart;
    public Button ButtonQuit;


    public void StartButton()
    {
        canvasMenu.SetActive(false);

    }

    public void Quit()
    {
        Debug.Log("has quit game.");
        Application.Quit();
    }



}
