using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacija : MonoBehaviour
{
    float rotate;

    private void Start()
    {
        rotate = 10.0f;
    }
    void Update()
    {
        transform.Rotate(new Vector3(1* rotate * Time.deltaTime, 1* rotate * Time.deltaTime, 0));
    }
}
