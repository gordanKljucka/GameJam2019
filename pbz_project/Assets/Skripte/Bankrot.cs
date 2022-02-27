using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bankrot : MonoBehaviour
{
    GameObject player;
    GameManager gm;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider player)
    {
        gm.GubitakZivota();
        
    }
}
