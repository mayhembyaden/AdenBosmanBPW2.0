using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxCamera : MonoBehaviour
{
    public ParallaxBackground pBackground;
    float oldPos;

    void Start()
    {
        oldPos = transform.position.x;
    }

    void Update()
    {
        pBackground.Move(oldPos - transform.position.x);
        oldPos = transform.position.x;
    }
}
