using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetro2 : MonoBehaviour
{

    private float previousTime;
    public float fallTime = 0.8f;


    // Update is called once per frame
    void Update()
    {
        if (Time.time - previousTime > fallTime)
        {
            transform.position += new Vector3(0, -1, 0);
            previousTime = Time.time;
        }

        if ( transform.position.y <= -15)
        {
            transform.position = new Vector3(0, 9, 0);

        }

    }
}
