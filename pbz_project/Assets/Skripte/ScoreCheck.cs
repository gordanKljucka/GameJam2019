using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCheck : MonoBehaviour
{
    GameObject player;
    GameManager gm;

    public GameObject gameOver;

    public Material[] skyboxes;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gm = GetComponent<GameManager>();
        InvokeRepeating("ScoreChecker", 1.5f, 1.5f);
        gameOver.SetActive(false);
        
    }

    public void ScoreChecker()
    {
        if(gm.score <= -2500)
        {
            player.SetActive(false);
            gameOver.SetActive(true);
            // zavrsi igru
        }

        //  NAPOMENA
        //   TARIFA JE FIKTIVNA !!! !!! !!! !!! !!!
        else if (gm.score <= -2000)
        {
            RenderSettings.skybox = skyboxes[0];
        }
        else if(gm.score <= -1000)//1 //  -   1000
        {
            RenderSettings.skybox = skyboxes[1];
        }
        else if(gm.score <= -500)//2 //  -500
        {
            RenderSettings.skybox = skyboxes[2];
        }
        else if(gm.score == 0)
        {
            RenderSettings.skybox = skyboxes[3];
        }
        else if (gm.score >= 500)  //  dva
        {
            RenderSettings.skybox = skyboxes[4];
        }
        else if (gm.score >= 1500)  //  tri
        {
            RenderSettings.skybox = skyboxes[5];
        }
        else if(gm.score >= 2500)   //  cetiri
        {
            RenderSettings.skybox = skyboxes[6];
        }
        
        //6//   zadnja
    }

    
}
