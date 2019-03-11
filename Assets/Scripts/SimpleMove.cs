﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float SpeedFactor = 1f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput =Input.GetAxisRaw("Horizontal");
        
        float So= transform.position.x;
        float S= So + HorizontalInput * SpeedFactor*Time.deltaTime;       
    transform.position = new Vector3(S, transform.position.y, transform.position.x);
    }
}
