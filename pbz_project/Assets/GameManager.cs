using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Text scoreTxt;
    public int score = 0;

    public string[] dobro;
    public string[] lose = new string[] { };
    public int[] vrijednost = new int[3] { 100, 200, 300};
    public Text opis;

    public GameObject losePanel;
    public Text status;

    public Button opet;
    public Button izlaz;

    public Text zivoti;
    public int playerLife = 3;

    private void Start()
    {
        PokaziScore();
        zivoti.text = playerLife + "X";
        losePanel.SetActive(false);
        dobro = new string[3] { "sjela para", "placa", "dobitak"};
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void PokaziScore()
    {
        scoreTxt.text = score + " kn";
    }

    public void GubitakZivota()
    {
        playerLife -= 1;
        zivoti.text = playerLife + "X";
        if (playerLife < 0)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerJump>().enabled = false;
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            status.text = "Izgubili ste sve živote. \n Pokušajte ponovo!";
            losePanel.SetActive(true);
        }
    }

    public void NovaIgre()
    {
        SceneManager.LoadScene(1);
    }
    public void IzlazIzIgre()
    {
        SceneManager.LoadScene(0);
    }

    public void Dodaj(int _int, string _str) //  kada collideamo sa necime
    {
        opis.text = "" + _str;
        score += _int;
        scoreTxt.text = score + " kn";
    }

    public void Oduzmi(int _int, string _str)
    {
        opis.text = "" + _str;
        score -= _int;
        scoreTxt.text = score + " kn";
    }
}


