using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public ParticleSystem exp;

    private void Start()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hit"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            exp.Play();
        }
    }

}
