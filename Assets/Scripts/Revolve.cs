using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Revolve : MonoBehaviour
{
    
    private float radius = 2.45f;
    private float newAngle;
    // Update is called once per frame

    void Update()
    {
        
        
        newAngle += 5f* Time.deltaTime;
        transform.position = new Vector3(radius*Mathf.Sin(newAngle), 0.5f, radius*Mathf.Cos(newAngle));
    }
}
