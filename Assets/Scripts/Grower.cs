using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{
    private int direction = 1;
    private Vector3 scaler = new Vector3(.01f, .01f, .01f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x > 3f){
            direction*=-1;
        }
        if(transform.localScale.x < .5f){
            direction*=-1;
        }
        transform.localScale += scaler*direction;
        transform.position += new Vector3(0f, .01f*direction, 0f);
    }
}
