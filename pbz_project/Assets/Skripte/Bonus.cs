using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    GameObject player;
    GameManager gm;
    SoundManager snd;
    //MeshRenderer mesh;
    MeshRenderer[] meshes;

    public string ime;
    public int value;
    public string opis;
    //int rnd;    //  random za eventove

    private void Start()
    {
        ime = this.gameObject.tag;
        //rnd = Random.Range(0, 3);
        player = GameObject.FindGameObjectWithTag("Player");
        gm = FindObjectOfType<GameManager>();
        snd = FindObjectOfType<SoundManager>();
        //mesh = GetComponentInChildren<MeshRenderer>();
        meshes = GetComponentsInChildren<MeshRenderer>();

        switch(ime)
        {
            case "petKuna":
                value = 5;
                opis = "Našli ste 5 kuna";
                break;
            case "pedeset":
                value = 50;
                opis = "Zaradili ste 50 kuna";
                break;
            case "sto":
                value = 100;
                opis = "Zaradili ste 100 kuna";
                break;
            case "Loto":
                value = 1000;
                opis = "JACKPOT!";
                break;
        }
    }

    private void OnTriggerEnter(Collider player)
    {
        //gm.score += 100;

        foreach(MeshRenderer msh in meshes)
        {
            msh.enabled = false;
        }
        gm.Dodaj(value, opis);
        gm.PokaziScore();
        snd.Bod();
        this.gameObject.SetActive(false);
    }
}
