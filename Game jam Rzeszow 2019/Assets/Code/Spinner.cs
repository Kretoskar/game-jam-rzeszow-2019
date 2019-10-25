﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float reducer;
    public float multiplier = 1;
    bool round1 = false;
    public bool isStoped = false;
    private bool startSpinning = false;

    void Start()
    {
        reducer = Random.Range(0.01f, 0.5f);
        Reset();
    }

    // Update is called once per frameQ
    void FixedUpdate()
    {
        if (startSpinning)
        {
            if (multiplier > 0)
            {
                transform.Rotate(Vector3.forward, 1 * multiplier);
            }
            else
            {
                isStoped = true;
            }

            if (multiplier < 20 && !round1)
            {
                multiplier += 0.1f;
            }
            else
            {
                round1 = true;
            }

            if (round1 && multiplier > 0)
            {
                multiplier -= reducer;
            }
        }
    }

    public void StartSpinning()
    {
        startSpinning = true;
    }

    void Reset()
    {
        multiplier = 1;
        reducer = Random.Range(0.01f, 0.5f);
        round1 = false;
        isStoped = false;
    }
}
