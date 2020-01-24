using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScript : MonoBehaviour
{
    public ParticleSystem explosion;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pickup"))
        {
            Explode();
            other.gameObject.SetActive(false);
        }


    }

    void Explode ()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject, exp.duration);
    }

}
