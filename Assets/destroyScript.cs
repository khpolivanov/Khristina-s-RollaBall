using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScript : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int count;
    AudioSource audio1;
    AudioSource winAudio;
    public ParticleSystem exp;

    private void Start()
    {
        AudioSource[] aSources = GetComponents<AudioSource>();
        ParticleSystem exp = GetComponent<ParticleSystem>();
        audio1 = aSources[0];
        winAudio = aSources[1];

        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    void FixedUpdate()
    {
        /*float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        if (Input.GetKeyDown("space") && rb.transform.position.y <= 0.5f)
        {
            Vector3 jump = new Vector3(0.0f, 250.0f, 0.0f);

            rb.AddForce(jump);
        }

        rb.AddForce(movement * speed);*/

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            audio1.Play();
            count++;
        }
    }


}
