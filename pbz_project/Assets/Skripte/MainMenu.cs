using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsPanel;
    public GameObject quitPanel;

    private void Start()
    {
        creditsPanel.SetActive(false);
        quitPanel.SetActive(false);
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Igra");
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
    }

    public void Back()
    {
        creditsPanel.SetActive(false);
    }

    public void Quiting()
    {
        quitPanel.SetActive(true);
        //Application.Quit();
    }

    public void Vrati()
    {
        quitPanel.SetActive(false);
    }
    public void PotvrdiQuit()
    {
        Application.Quit();
    }
}
