using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gubitak : MonoBehaviour
{
    GameObject player;
    GameManager gm;
    SoundManager snd;
    MeshRenderer mesh;

    public string ime;
    public int value;
    public string opis;

    private void Start()
    {
        ime = this.gameObject.tag;
        player = GameObject.FindGameObjectWithTag("Player");
        gm = FindObjectOfType<GameManager>();
        snd = FindObjectOfType<SoundManager>();

        mesh = GetComponentInChildren<MeshRenderer>();

        switch(ime)
        {
            case "gorivo":
                value = 100;
                opis = "Kupili ste gorivo za 100kn";
                break;
            case "racun":
                value = 150;
                opis = "Platili ste račune za 150 kn";
                break;
            case "kredit":
                value = 300;
                opis = "Platili ste ratu kredita 300 kn";
                break;
            case "Bankrot":
                value = 1500;
                opis = "Bankrotirali ste";
                break;
                
            //gorivo
            //racun
            //  kredit
        }
    }

    private void OnTriggerEnter(Collider player)
    {
        //GameManager.score -= 100;
        mesh.enabled = false;
        gm.Oduzmi(value, opis);
        gm.PokaziScore();
        snd.Gubitak();
        this.gameObject.SetActive(false);
    }
}
