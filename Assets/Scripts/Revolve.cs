using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Revolve : MonoBehaviour
{

    public float radius = 2.45f;
    public float newAngle;
    // Update is called once per frame

    void FixedUpdate()
    {

    newAngle += 3f* Time.deltaTime;
    transform.position = new Vector3(radius*Mathf.Sin(newAngle), .5f, radius*Mathf.Cos(newAngle));
    }


}
