using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DnoDna : MonoBehaviour
{
    GameManager gm;
    public GameObject player;
    public Text opis;
    

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        gm.GubitakZivota();
        player.transform.position = new Vector3(0, 0, 0);
        player.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        opis.text = "Izbjegavajte dno";
    }
}
