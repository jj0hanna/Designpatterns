using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody body;
    [SerializeField] private float gravityscale = 8;
    private float yhight = 10;
    private float yminHight = 1;
    private bool isOnmaxHight;
    void Start()
    {
        isOnmaxHight = false;
    }

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (transform.position.y >= yhight)
        {
            isOnmaxHight = true;
            body.velocity += new Vector3(0, -1, 0) * gravityscale;
        }
        if (transform.position.y <= yminHight && isOnmaxHight)
        {
            body.velocity = new Vector3(0, 0, 0);
        }
    }
    
}
