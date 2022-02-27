using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //  ??

public class SkyBox : MonoBehaviour
{
    public SkyBox sky1;

    public Material mater1;

    Scene scena;

    private void Start()
    {
        RenderSettings.skybox = mater1;
    }

}
