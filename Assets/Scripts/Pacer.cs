using UnityEngine;
using System.Collections;

public class Pacer : MonoBehaviour
{

    /*public float speed = 5.0f;
    private float zMax = 7.5f;
    public float zMin = -7.5f; //starting position
    private int direction = 1; //positive to start

    void Update()
        {
            float zNew = transform.position.z +
            direction* speed *Time.deltaTime;
            if (zNew >= zMax)
            {
                zNew = zMax;
                direction *= -1;
            }
            else if (zNew <= zMin)
            {
                zNew = zMin;
                direction *= -1;
            }
            transform.position = new Vector3(7.5f, 0.75f, zNew);
            }*/

    public Vector3 pos1 = new Vector3(-4, 0, 1);
    public Vector3 pos2 = new Vector3(4, 0, 1);
    public float speed = .5f;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }

    }