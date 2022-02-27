using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    float speed = 8;

    private void Update()
    {
        transform.Translate(new Vector3(0, 0, -1 * speed * Time.deltaTime));
    }
}
