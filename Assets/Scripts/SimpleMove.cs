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
        float verticalInput = Input.GetAxisRaw("Vertical"); 
        Vector3 velocity = new Vector3(HorizontalInput, verticalInput, 0f)*SpeedFactor;
               
        transform.position = transform.position + velocity *Time.deltaTime;
    }
}
