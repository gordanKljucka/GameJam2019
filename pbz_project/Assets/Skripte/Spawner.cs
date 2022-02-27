using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bankrot;
    public GameObject loto;
    //public int[] pozicije = new int[5] { -4, -2, 0, 2, 4 };
    public Transform[] spawn = new Transform[5];                // spawn points
    public List<GameObject> objekti = new List<GameObject>();
    public GameObject prefab;
    public int ritam;

    SoundManager snd;

    private void Start()
    {
        snd = FindObjectOfType<SoundManager>();
        //ritam = Random.Range(1, 3);
        InvokeRepeating("Spawn", 1, 1);
        Spawn();
    }


    void Spawn()
    {
        //ritam = Random.Range(4, 10);
        int roll = Random.Range(0, 11);
        int goodbad;
        if(roll < 10)
        {
            int temp = Random.Range(0, objekti.Count);
            prefab = objekti[temp];
        }
        else if(roll == 10)
        {
            int newRoll = Random.Range(0, 2);
            if(newRoll == 0)
            {
                prefab = bankrot;
            }
            else
            {
                prefab = loto;
            }
        }
        GameObject clone_object;
        clone_object = Instantiate(prefab, spawn[Random.Range(0, spawn.Length-1)].position, Quaternion.identity);
        //snd.Spawn();
    }
}
